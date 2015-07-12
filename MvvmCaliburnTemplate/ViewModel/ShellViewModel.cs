﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace MvvmCaliburnTemplate.ViewModel
{
    [Export]
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive
    {
        #region Members

        #endregion

        #region Properties

        #endregion

        #region Constructors

        [ImportingConstructor]
        public ShellViewModel([ImportMany] IEnumerable<IScreen> viewModels)
        {
            Dictionary<Type, int> tabOrder = new Dictionary<Type, int>();

            IOrderedEnumerable<IScreen> orderedScreens = viewModels.OrderBy(t => tabOrder[t.GetType()]);

            Items.AddRange(viewModels);
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public Methods

        #endregion

    }
}
