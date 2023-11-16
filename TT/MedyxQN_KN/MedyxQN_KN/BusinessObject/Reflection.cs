using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Web.Compilation;

namespace HTC.BusinessObject
{
    public class Reflection
    {
        #region Public Shared Methods

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="ObjectProviderType">The type of Object to create (data/navigation)</param>
        /// <returns>The created Object</returns>
        /// <remarks>Overload for creating an object from a Provider configured in web.config</remarks>
        /// <history>
        /// 	[cnurse]	    10/13/2005	Documented
        /// </history>
        /// -----------------------------------------------------------------------------
        public static object CreateObject(string ObjectProviderType)
        {
            return CreateObject(ObjectProviderType, true);
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="ObjectProviderType">The type of Object to create (data/navigation)</param>
        /// <param name="UseCache">Caching switch</param>
        /// <returns>The created Object</returns>
        /// <remarks>Overload for creating an object from a Provider configured in web.config</remarks>
        /// <history>
        /// 	[cnurse]	    10/13/2005	Documented
        /// </history>
        /// -----------------------------------------------------------------------------
        public static object CreateObject(string ObjectProviderType, bool UseCache)
        {
            return CreateObject(ObjectProviderType, "", "", "", UseCache);
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="ObjectProviderType">The type of Object to create (data/navigation)</param>
        /// <param name="ObjectNamespace">The namespace of the object to create.</param>
        /// <param name="ObjectAssemblyName">The assembly of the object to create.</param>
        /// <returns>The created Object</returns>
        /// <remarks>Overload for creating an object from a Provider including NameSpace and 
        /// AssemblyName ( this allows derived providers to share the same config )</remarks>
        /// <history>
        /// 	[cnurse]	    10/13/2005	Documented
        /// </history>
        /// -----------------------------------------------------------------------------
        public static object CreateObject(string ObjectProviderType, string ObjectNamespace, string ObjectAssemblyName)
        {
            return CreateObject(ObjectProviderType, "", ObjectNamespace, ObjectAssemblyName, true);
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="ObjectProviderType">The type of Object to create (data/navigation)</param>
        /// <param name="ObjectNamespace">The namespace of the object to create.</param>
        /// <param name="ObjectAssemblyName">The assembly of the object to create.</param>
        /// <param name="UseCache">Caching switch</param>
        /// <returns>The created Object</returns>
        /// <remarks>Overload for creating an object from a Provider including NameSpace and 
        /// AssemblyName ( this allows derived providers to share the same config )</remarks>
        /// <history>
        /// 	[cnurse]	    10/13/2005	Documented
        /// </history>
        /// -----------------------------------------------------------------------------
        public static object CreateObject(string ObjectProviderType, string ObjectNamespace, string ObjectAssemblyName, bool UseCache)
        {
            return CreateObject(ObjectProviderType, "", ObjectNamespace, ObjectAssemblyName, UseCache);
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="ObjectProviderType">The type of Object to create (data/navigation)</param>
        /// <param name="ObjectProviderName">The name of the Provider</param>
        /// <param name="ObjectNamespace">The namespace of the object to create.</param>
        /// <param name="ObjectAssemblyName">The assembly of the object to create.</param>
        /// <returns>The created Object</returns>
        /// <remarks>Overload for creating an object from a Provider including NameSpace, 
        /// AssemblyName and ProviderName</remarks>
        /// <history>
        /// 	[cnurse]	    10/13/2005	Documented
        /// </history>
        /// -----------------------------------------------------------------------------
        public static object CreateObject(string ObjectProviderType, string ObjectProviderName, string ObjectNamespace, string ObjectAssemblyName)
        {
            return CreateObject(ObjectProviderType, ObjectProviderName, ObjectNamespace, ObjectAssemblyName, true);
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="ObjectProviderType">The type of Object to create (data/navigation)</param>
        /// <param name="ObjectProviderName">The name of the Provider</param>
        /// <param name="ObjectNamespace">The namespace of the object to create.</param>
        /// <param name="ObjectAssemblyName">The assembly of the object to create.</param>
        /// <param name="UseCache">Caching switch</param>
        /// <returns>The created Object</returns>
        /// <remarks>Overload for creating an object from a Provider including NameSpace, 
        /// AssemblyName and ProviderName</remarks>
        /// <history>
        /// 	[cnurse]	    10/13/2005	Documented
        /// </history>
        /// -----------------------------------------------------------------------------
        public static object CreateObject(string ObjectProviderType, string ObjectProviderName, string ObjectNamespace, string ObjectAssemblyName, bool UseCache)
        {
            return CreateObject(ObjectProviderType, ObjectProviderName, ObjectNamespace, ObjectAssemblyName, UseCache, true);
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="ObjectProviderType">The type of Object to create (data/navigation)</param>
        /// <param name="ObjectProviderName">The name of the Provider</param>
        /// <param name="ObjectNamespace">The namespace of the object to create.</param>
        /// <param name="ObjectAssemblyName">The assembly of the object to create.</param>
        /// <param name="UseCache">Caching switch</param>
        /// <param name="fixAssemblyName">Whether append provider name as part of the assembly name.</param>
        /// <returns>The created Object</returns>
        /// <remarks>Overload for creating an object from a Provider including NameSpace, 
        /// AssemblyName and ProviderName</remarks>
        /// <history>
        /// 	[benz]	    2/16/2012	Created
        /// </history>
        /// -----------------------------------------------------------------------------
        public static object CreateObject(string ObjectProviderType, string ObjectProviderName, string ObjectNamespace, string ObjectAssemblyName, bool UseCache, bool fixAssemblyName)
        {
            string TypeName = "";

            //get the provider configuration based on the type
            if (!String.IsNullOrEmpty(ObjectNamespace) && !String.IsNullOrEmpty(ObjectAssemblyName))
            {
                //if both the Namespace and AssemblyName are provided then we will construct an "assembly qualified typename" - ie. "NameSpace.ClassName, AssemblyName" 
                if (String.IsNullOrEmpty(ObjectProviderName))
                {
                    //dynamically create the typename from the constants ( this enables private assemblies to share the same configuration as the base provider ) 
                    TypeName = ObjectNamespace + "." + "SqlDataProvider" + ", " + ObjectAssemblyName + (fixAssemblyName ? "." + "SqlDataProvider" : string.Empty);
                }
                else
                {
                    //dynamically create the typename from the constants ( this enables private assemblies to share the same configuration as the base provider ) 
                    TypeName = ObjectNamespace + "." + ObjectProviderName + ", " + ObjectAssemblyName + (fixAssemblyName ? "." + ObjectProviderName : string.Empty);
                }
            }
            else
            {
                //if only the Namespace is provided then we will construct an "full typename" - ie. "NameSpace.ClassName" 
                if (!String.IsNullOrEmpty(ObjectNamespace))
                {
                    if (String.IsNullOrEmpty(ObjectProviderName))
                    {
                        //dynamically create the typename from the constants ( this enables private assemblies to share the same configuration as the base provider ) 
                        TypeName = ObjectNamespace + "." + "SqlDataProvider";
                    }
                    else
                    {
                        //dynamically create the typename from the constants ( this enables private assemblies to share the same configuration as the base provider ) 
                        TypeName = ObjectNamespace + "." + ObjectProviderName;
                    }
                }
                else
                {
                    //if neither Namespace or AssemblyName are provided then we will get the typename from the default provider 
                    if (String.IsNullOrEmpty(ObjectProviderName))
                    {
                        //get the typename of the default Provider from web.config
                        TypeName = "Nobita.Data.SqlDataProvider, Nobita.SqlDataProvider";
                    }
                    else
                    {
                        //get the typename of the specified ProviderName from web.config 
                        TypeName = "Nobita.Data.SqlDataProvider, Nobita.SqlDataProvider";
                    }
                }
            }
            return CreateObject(TypeName, TypeName, UseCache);
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="TypeName">The fully qualified TypeName</param>
        /// <param name="CacheKey">The Cache Key</param>
        /// <returns>The created Object</returns>
        /// <remarks>Overload that takes a fully-qualified typename and a Cache Key</remarks>
        /// <history>
        /// 	[cnurse]	    10/13/2005	Documented
        /// </history>
        /// -----------------------------------------------------------------------------
        public static object CreateObject(string TypeName, string CacheKey)
        {
            return CreateObject(TypeName, CacheKey, true);
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="TypeName">The fully qualified TypeName</param>
        /// <param name="CacheKey">The Cache Key</param>
        /// <param name="UseCache">Caching switch</param>
        /// <returns>The created Object</returns>
        /// <remarks>Overload that takes a fully-qualified typename and a Cache Key</remarks>
        /// <history>
        /// 	[cnurse]	    10/13/2005	Documented
        /// </history>
        /// -----------------------------------------------------------------------------
        public static object CreateObject(string TypeName, string CacheKey, bool UseCache)
        {
            return Activator.CreateInstance(CreateType(TypeName, CacheKey, UseCache));
           // return Activator.CreateInstance(typeof(StringBuilder), TypeName);
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <typeparam name="T">The type of object to create</typeparam>
        /// <returns></returns>
        /// <remarks>Generic version</remarks>
        /// -----------------------------------------------------------------------------
        public static T CreateObject<T>()
        {
            //dynamically create the object
            return Activator.CreateInstance<T>();
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Creates an object
        /// </summary>
        /// <param name="type">The type of object to create</param>
        /// <returns></returns>
        /// -----------------------------------------------------------------------------
        public static object CreateObject(Type type)
        {
            return Activator.CreateInstance(type);
        }

        public static Type CreateType(string TypeName)
        {
            return CreateType(TypeName, "", true, false);
        }

        public static Type CreateType(string TypeName, bool IgnoreErrors)
        {
            return CreateType(TypeName, "", true, IgnoreErrors);
        }

        public static Type CreateType(string TypeName, string CacheKey, bool UseCache)
        {
            return CreateType(TypeName, CacheKey, UseCache, false);
        }

        public static Type CreateType(string TypeName, string CacheKey, bool UseCache, bool IgnoreErrors)
        {
            if (String.IsNullOrEmpty(CacheKey))
            {
                CacheKey = TypeName;
            }
            Type type =  type = BuildManager.GetType(CacheKey, true, true);

        
            return type;
        }

        public static object CreateInstance(Type Type)
        {
            if (Type != null)
            {
                return Type.InvokeMember("", BindingFlags.CreateInstance, null, null, null, null);
            }
            else
            {
                return null;
            }
        }

        public static object GetProperty(Type Type, string PropertyName, object Target)
        {
            if (Type != null)
            {
                return Type.InvokeMember(PropertyName, BindingFlags.GetProperty, null, Target, null);
            }
            else
            {
                return null;
            }
        }

        public static void SetProperty(Type Type, string PropertyName, object Target, object[] Args)
        {
            if (Type != null)
            {
                Type.InvokeMember(PropertyName, BindingFlags.SetProperty, null, Target, Args);
            }
        }

        public static void InvokeMethod(Type Type, string PropertyName, object Target, object[] Args)
        {
            if (Type != null)
            {
                Type.InvokeMember(PropertyName, BindingFlags.InvokeMethod, null, Target, Args);
            }
        }

        //dynamically create a default Provider from a ProviderType - this method was used by the CachingProvider to avoid a circular dependency
        [Obsolete("This method has been deprecated. Please use CreateObject(ByVal ObjectProviderType As String, ByVal UseCache As Boolean) As Object")]
        internal static object CreateObjectNotCached(string ObjectProviderType)
        {
            string TypeName = "";
            Type objType = null;

         
            //get the typename of the Base DataProvider from web.config
            TypeName = "Nobita.Data.SqlDataProvider, Nobita.SqlDataProvider";
            try
            {
                //use reflection to get the type of the class
                objType = BuildManager.GetType(TypeName, true, true);
            }
            catch (Exception ex)
            {
                //could not load the type
                
            }

            //dynamically create the object
            return Activator.CreateInstance(objType);
        }

        #endregion
    }
}
