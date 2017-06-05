﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guianet.Models.Sessions
{
    public class SearchCategoryCL
    {
        #region Constructor
        public SearchCategoryCL(string CategoryName)
        {
            Category = CategoryName;
        }

        #endregion

        #region Member

        private string Category;

        #endregion

        #region Properties

        public string CategoryName
        {
            get
            {
                return Category;
            }
            set
            {
                Category = value;
            }
        }
        #endregion
    }
}