using System;
using System.Collections.Generic;
using System.Text;

namespace HTC.Business
{
    public static class Assignment
    {
        #region Data Access

        public static void AddWorkingSpaceToUser(int UserId, int LocationId)
        {
            DataProvider.Instance().AssignWorkingSpace(UserId, LocationId);
        }

        public static void RemoveWorkingSpaceFromUser(int UserId, int LocationId)
        {
            DataProvider.Instance().RemoveWorkingSpace(UserId, LocationId);
        }

        public static void AddRoleToUser(int UserId, int RoleId)
        {
            DataProvider.Instance().AssignRole(UserId, RoleId);
        }

        public static void RemoveRoleFromUser(int UserId, int RoleId)
        {
            DataProvider.Instance().RemoveRoleFromUser(UserId, RoleId);
        }

              public static void AddWorkflowToRole(int idRole, int idWorkflow)
        {
            DataProvider.Instance().AddWorkflowToRole(idRole, idWorkflow);
        }
        public static void RemoveWorkflowFromRole(int idRole, int idWorkflow)
        {
            DataProvider.Instance().RemoveWorkflowFromRole(idRole, idWorkflow);
        }
        public static void InsertWorkflowName(string workflowName, string className, string assemblyName, string description)
        {
            HTC.Business.Workflow wf;
            wf = HTC.Business.Workflow.NewWorkflow();
            wf.WorkflowName = workflowName;
            wf.ClassName = className;
            wf.Description = description;
            wf.AssemblyName = assemblyName;
            wf.Save();
        }

        #endregion

      
    }
}
