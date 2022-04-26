using Lana_jewelry.Aids;
using System.Reflection;
using System.Diagnostics;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lana_jewelry.Domain;

namespace Lana_jewelry.Tests
{

    public abstract class BaseTests<TClass, TBaseClass> : TypeTests where TClass : class where TBaseClass : class {
        protected TClass obj;
        protected BaseTests() => obj = createObj();

        protected abstract TClass createObj();
        protected void isProperty<T>(T? value = default, bool isReadOnly = false, string? callingMethod=null) {
            callingMethod ??= nameof(isProperty);
            var actual = getProperty( ref value, isReadOnly, callingMethod);
            areEqual(value, actual);
        }
        protected object? getProperty<T>(ref T? value, bool isReadOnly, string callingMethod){
            var memberName = getCallingMember(callingMethod).Replace("Test", string.Empty);
            var propertyInfo = obj.GetType().GetProperty(memberName);
            isNotNull(propertyInfo);
            if (isNullOrDefault(value)) value = random<T>();
            if (canWrite(propertyInfo, isReadOnly)) propertyInfo.SetValue(obj, value);
            return propertyInfo.GetValue(obj);
        }
        protected void isReadOnly<T>(T? value) => isProperty(value, true, nameof(isReadOnly));
        protected object? isReadOnly<T>(string? callingMethod= null){
            var v=default(T);
            return getProperty(ref v, true, callingMethod?? nameof(isReadOnly));
        }
        private static bool isNullOrDefault<T>(T? value) => value?.Equals(default(T)) ?? true;
        private static bool canWrite(PropertyInfo i, bool isReadOnly)
        {
            var canWrite = i?.CanWrite ?? false;
            areEqual(canWrite, !isReadOnly);
            return canWrite;
        }
        private static T? random<T>() => GetRandom.Value<T>();
        private static string getCallingMember(string memberName)
        {
            var s = new StackTrace();
            var isNext = false;
            for (var i = 0; i < s.FrameCount; i++)
            {
                var n = s.GetFrame(i)?.GetMethod()?.Name ?? string.Empty;
                if (n is "MoveNext" or "Start") continue;
                if (isNext) return n;
                if (n == memberName) isNext = true;
            }
            return string.Empty;
        }
        internal protected static void arePropertiesEqual(object x, object y) {
            var e = Array.Empty<PropertyInfo>();
            var px = x?.GetType()?.GetProperties() ?? e;
            var hasProperites = false;
            foreach (var p in px) {
                var a = p.GetValue(x, null);
                var py = y?.GetType()?.GetProperty(p.Name);
                if (py is null) continue;
                var b = py?.GetValue(y, null);
                areEqual(a, b);
                hasProperites = true;
            }
            isTrue(hasProperites, $"No properties found for {x}");
        }
        protected void testItem<TRepo, TObj, TData>(string id, Func<TData, TObj> toObj, Func<TObj?> getObj)
          where TRepo : class, IRepo<TObj>
          where TObj : UniqueEntity
        {

            var c = isReadOnly<TObj>(nameof(testItem));
            isNotNull(c);
            isInstanceOfType(c, typeof(TObj));

            var r = GetRepo.Instance<TRepo>();

            var d = GetRandom.Value<TData>();
            d.Id = id;

            var cnt = GetRandom.Int32(0, 30);
            var idx = GetRandom.Int32(0, cnt);
            for (var i = 0; i < cnt; i++)
            {
                var x = (i == idx) ? d : GetRandom.Value<TData>();
                isNotNull(x);
                r?.Add(toObj(x));
            }

            r.PageSize = 30;
            areEqual(cnt, r.Get().Count);

            arePropertiesEqual(d, getObj());
        }

        [TestMethod] public void IsCorrectBaseClassTest() => areEqual(typeof(TClass).BaseType, typeof(TBaseClass));
    }
}


