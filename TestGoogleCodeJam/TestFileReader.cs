﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using GoogleCodeJam.Case;
using GoogleCodeJam.Interpreter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestGoogleCodeJam
{
    [TestClass]
    public class TestFileReader
    {
        [TestMethod]
        public void TestMethodReadFile()
        {
            var fileReader = new GoogleCodeJam.FileIO.FileManager();
            var output = fileReader.ReadFile();
            Assert.AreEqual(31, output.Count);
            Assert.AreEqual("10", output[0][0]);
        }

        [TestMethod]
        public void TestMethodLoadClass()
        {
            object obj = Activator.CreateInstance(Type.GetType("GoogleCodeJamPractice.Problem, GoogleCodeJamPractice", true));
        }

        [TestMethod]
        public void TestMethodGetPropertyInfos()
        {
            var _dict = new Dictionary<string, int>();

            PropertyInfo[] props = typeof(Problem).GetProperties();
            foreach (PropertyInfo prop in props)
            {
                object[] attrs = prop.GetCustomAttributes(true);
                foreach (object attr in attrs)
                {
                    var authAttr = attr as InterpreterAttribute;
                    if (authAttr != null)
                    {
                        string propName = prop.Name;
                        var auth = authAttr.Order;

                        _dict.Add(propName, auth);
                    }
                }
            }
            var juan = _dict;
        }

    }
}
