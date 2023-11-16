using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business
{
    [Serializable()]
    public class Workflow: BusinessBase<Workflow>
    {
        #region Business Methods

        int _IdWorkflow;
        public int IdWorkflow
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _IdWorkflow;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_IdWorkflow.Equals(value))
                {
                    _IdWorkflow = value;
                    PropertyHasChanged();
                }
            }
        }

        string _WorkflowName = string.Empty;
        public string WorkflowName
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _WorkflowName;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_WorkflowName.Equals(value))
                {
                    _WorkflowName = value;
                    PropertyHasChanged();
                }
            }
        }

        string _ClassName = string.Empty;
        public string ClassName
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _ClassName;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_ClassName.Equals(value))
                {
                    _ClassName = value;
                    PropertyHasChanged();
                }
            }
        }

        string _AssemblyName = string.Empty;
        public string AssemblyName
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _AssemblyName;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_AssemblyName.Equals(value))
                {
                    _AssemblyName = value;
                    PropertyHasChanged();
                }
            }
        }

        string _Description = string.Empty;
        public string Description
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _Description;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                CanWriteProperty(true);
                if (!_Description.Equals(value))
                {
                    _Description = value;
                    PropertyHasChanged();
                }
            }
        }

        protected override object GetIdValue()
        {
            return _IdWorkflow;
        }

        #endregion

        #region Validation Rules

        protected override void AddBusinessRules()
        {
            // TODO: add validation rules
        }

        #endregion

        #region Authorization Rules

        protected override void AddAuthorizationRules()
        {
            // TODO: add authorization rules
        }

        #endregion

        #region Factory Methods

        public static Workflow NewWorkflow()
        {
            return DataPortal.Create<Workflow>();    
        }


        public static Workflow GetWorkflow(int id)
        {
            return DataPortal.Fetch<Workflow>(new Criteria(id));
        }

        public static void DeleteWorkflow(int id)
        {
            DataPortal.Delete(new Criteria(id));
        }

        public Workflow()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private int mId;
            public int Id
            {
                get
                {
                    return mId;
                }
            }
            public Criteria(int id)
            {
                mId = id;
            }
        }

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetWorkflow(criteria.Id)))
            {
                if (dr.Read())
                {
                    _IdWorkflow = dr.GetInt32("IdWorkflow");
                    _WorkflowName = dr.GetString("WorkflowName");
                    _ClassName = dr.GetString("ClassName");
                    _AssemblyName = dr.GetString("AssemblyName");
                    _Description = dr.GetString("Description");
                }
            }
        }

        protected override void DataPortal_Insert()
        {
            DataProvider.Instance().InsertWorkflow(_WorkflowName, _ClassName,_AssemblyName, _Description);
        }

        protected override void DataPortal_Update()
        {
            // TODO: update object's data
        }

        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new Criteria(_IdWorkflow));
        }

        private void DataPortal_Delete(Criteria criteria)
        {
            // TODO: delete object's data
        }

        #endregion
    }
}
