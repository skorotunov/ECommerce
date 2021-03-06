﻿using Domain;
using System;
using System.Configuration;
using System.Web.Mvc;

namespace WebUI
{
    public class CompositionRoot
    {
        private readonly IControllerFactory controllerFactory;

        public CompositionRoot()
        {
            this.controllerFactory = CompositionRoot.CreateControllerFactory();
        }

        public IControllerFactory ControllerFactory
        {
            get { return this.controllerFactory; }
        }

        private static IControllerFactory CreateControllerFactory()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CommerceObjectContext"].ConnectionString;
            string productRepositoryTypeName = ConfigurationManager.AppSettings["ProductRepositoryType"];
            var productRepositoryType = Type.GetType(productRepositoryTypeName, true);
            var repository = (ProductRepository)Activator.CreateInstance(productRepositoryType, connectionString);

            var controllerFactory = new CommerceControllerFactory(repository);

            return controllerFactory;
        }
    }
}