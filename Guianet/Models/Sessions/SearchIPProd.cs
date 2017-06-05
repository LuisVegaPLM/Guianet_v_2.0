﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guianet.Models.Sessions
{
    public class SearchIPProd
    {
        #region Constructor
        public SearchIPProd(string ProductName)
        {
            Product = ProductName;
        }

        #endregion

        #region Member

        private string Product;

        #endregion

        #region Properties

        public string ProductName
        {
            get
            {
                return Product;
            }
            set
            {
                Product = value;
            }
        }
        #endregion
    }
}