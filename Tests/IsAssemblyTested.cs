using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Lana_jewelry.Tests{
    public abstract class IsAssemblyTested :TestAsserts {
        private Assembly? testingAssembly;
        private Assembly? assemblyToBeTested;
        private List<Type>? testingTypes;
        private List<Type>? typesToBeTested;
        private string? namespaceOfTest;
        private string? namespaceOfType;

        [TestMethod] public void IsAllTested() => isAllTested();

        protected virtual void isAllTested() {
            testingAssembly = getAssembly(this);
            testingTypes = getTypes(testingAssembly);
            namespaceOfTest = getNamespace(this);
            namespaceOfType = removeTestsTagFrom(namespaceOfTest);
            assemblyToBeTested = getAssembly(namespaceOfType);
            typesToBeTested = getTypes(assemblyToBeTested);
            removeNotNeedTesting();
            removeTested();
            if (allAreTested()) return;
            reportNotAllIsTested();
        }

        private string? removeTestsTagFrom(string? s) {
            throw new NotImplementedException();
        }

        private string? getNamespace(object o) {
            throw new NotImplementedException();
        }
        private Assembly? getAssembly(object o) {
            throw new NotImplementedException();
        }

        private List<Type>? getTypes(Assembly? a) {
            throw new NotImplementedException();
        }

        private void reportNotAllIsTested() {
            throw new NotImplementedException();
        }

        private bool allAreTested() {
            throw new NotImplementedException();
        }

        private void removeTested() {
            throw new NotImplementedException();
        }

        private void removeNotNeedTesting() {
            throw new NotImplementedException();
        }
    }
}
