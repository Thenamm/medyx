using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Reflection;
namespace HTC.BusinessObject.Data
{
    public class Null
    {
        //public const System.DateTime NULL_DATE = "1/1/0001 12:00:00 AM";
        //public const System.DateTime MIN_DATE = "1/1/1753 12:00:00 AM";

        //public const System.DateTime MAX_DATE = "12/31/9999 12:00:00 AM";
        // define application encoded null values 
        public static short NullShort
        {
            get { return short.MinValue; }
        }
        public static int NullInteger
        {
            get { return int.MinValue; }
        }

        public static long NullLong
        {
            get { return long.MinValue; }
        }

        public static float NullSingle
        {
            get { return float.MinValue; }
        }
        public static double NullDouble
        {
            get { return double.MinValue; }
        }
        public static decimal NullDecimal
        {
            get { return decimal.MinValue; }
        }
        public static System.DateTime NullDate
        {
            get { return System.DateTime.MinValue; }
        }
        public static string NullString
        {
            get { return ""; }
        }
        public static bool NullBoolean
        {
            get { return false; }
        }
        public static Guid NullGuid
        {
            get { return Guid.Empty; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objField"></param>
        /// <param name="objDefault"></param>
        /// <returns></returns>
        public static T SetNull<T>(object objField, T objDefault)
        {
            if (object.ReferenceEquals(objField, DBNull.Value) || objField == null || Null.IsNull(objField))
            {
                return objDefault;
            }
            else
            {
                return (T)objField;
            }
        }

        // sets a field to an application encoded null value ( used in BLL layer )
        public static object SetNull(object objValue, object objField)
        {
            object functionReturnValue = null;
            if (Information.IsDBNull(objValue))
            {
                if (objField is short)
                {
                    functionReturnValue = NullShort;
                }
                else if (objField is int)
                {
                    functionReturnValue = NullInteger;
                }
                else if (objField is long)
                {
                    functionReturnValue = NullLong;
                }
                else if (objField is float)
                {
                    functionReturnValue = NullSingle;
                }
                else if (objField is double)
                {
                    functionReturnValue = NullDouble;
                }
                else if (objField is decimal)
                {
                    functionReturnValue = NullDecimal;
                }
                else if (objField is System.DateTime)
                {
                    functionReturnValue = NullDate;
                }
                else if (objField is string)
                {
                    functionReturnValue = NullString;
                }
                else if (objField is bool)
                {
                    functionReturnValue = NullBoolean;
                }
                else if (objField is Guid)
                {
                    functionReturnValue = NullGuid;
                    // complex object
                }
                else
                {
                    functionReturnValue = null;
                }
                // return value
            }
            else
            {
                functionReturnValue = objValue;
            }
            return functionReturnValue;
        }

        public static object SetNullValue(object objField)
        {
            if (objField is short)
            {
                return NullShort;
            }
            else if (objField is int)
            {
                return NullInteger;
            }
            else if (objField is long)
            {
                return NullLong;
            }
            else if (objField is float)
            {
                return NullSingle;
            }
            else if (objField is double)
            {
                return NullDouble;
            }
            else if (objField is decimal)
            {
                return NullDecimal;
            }
            else if (objField is System.DateTime)
            {
                return NullDate;
            }
            else if (objField is string)
            {
                return NullString;
            }
            else if (objField is bool)
            {
                return NullBoolean;
            }
            else if (objField is Guid)
            {
                return NullGuid;
                // complex object
            }
            else
            {
                return null;
            }
        }

        public static object SetNullValue(Type objType)
        {
            switch (objType.Name)
            {
                case "Short":
                case "Int16":
                    return NullShort;
                case "Int32":
                case "Integer":
                    return NullInteger;
                case "Int64":
                case "Long":
                    return NullLong;
                case "Single":
                    return NullSingle;
                case "Double":
                    return NullDouble;
                case "Decimal":
                    return NullDecimal;
                case "Date":
                case "DateTime":
                    return NullDate;
                case "String":
                    return NullString;
                case "Boolean":
                    return NullBoolean;
                default:
                    // complex object
                    return null;
            }
        }

        // sets a field to an application encoded null value ( used in BLL layer )
        public static object SetNull(PropertyInfo objPropertyInfo)
        {
            object functionReturnValue = null;
            switch (objPropertyInfo.PropertyType.ToString())
            {
                case "System.Int16":
                    functionReturnValue = NullShort;
                    break;
                case "System.Int32":
                    functionReturnValue = NullInteger;
                    break;
                case "System.Int64":
                    functionReturnValue = NullLong;
                    break;
                case "System.Single":
                    functionReturnValue = NullSingle;
                    break;
                case "System.Double":
                    functionReturnValue = NullDouble;
                    break;
                case "System.Decimal":
                    functionReturnValue = NullDecimal;
                    break;
                case "System.DateTime":
                    functionReturnValue = NullDate;
                    break;
                case "System.String":
                case "System.Char":
                    functionReturnValue = NullString;
                    break;
                case "System.Boolean":
                    functionReturnValue = NullBoolean;
                    break;
                case "System.Guid":
                    functionReturnValue = NullGuid;
                    break;
                default:
                    // Enumerations default to the first entry
                    Type pType = objPropertyInfo.PropertyType;
                    if (pType.BaseType.Equals(typeof(System.Enum)))
                    {
                        System.Array objEnumValues = System.Enum.GetValues(pType);
                        Array.Sort(objEnumValues);
                        functionReturnValue = System.Enum.ToObject(pType, objEnumValues.GetValue(0));
                        // complex object
                    }
                    else
                    {
                        functionReturnValue = null;
                    }
                    break;
            }
            return functionReturnValue;
        }

        // convert an application encoded null value to a database null value ( used in DAL )
        public static object GetNull(object objField, object objDBNull)
        {
            object functionReturnValue = null;
            functionReturnValue = objField;
            if (objField == null)
            {
                functionReturnValue = objDBNull;
            }
            else if (objField is short)
            {
                if (Convert.ToInt16(objField) == NullShort)
                {
                    functionReturnValue = objDBNull;
                }
            }
            else if (objField is int)
            {
                if (Convert.ToInt32(objField) == NullInteger)
                {
                    functionReturnValue = objDBNull;
                }
            }
            else if (objField is long)
            {
                if (Convert.ToInt64(objField) == NullLong)
                {
                    functionReturnValue = objDBNull;
                }
            }
            else if (objField is float)
            {
                if (Convert.ToSingle(objField) == NullSingle)
                {
                    functionReturnValue = objDBNull;
                }
            }
            else if (objField is double)
            {
                if (Convert.ToDouble(objField) == NullDouble)
                {
                    functionReturnValue = objDBNull;
                }
            }
            else if (objField is decimal)
            {
                if (Convert.ToDecimal(objField) == NullDecimal)
                {
                    functionReturnValue = objDBNull;
                }
            }
            else if (objField is System.DateTime)
            {
                // compare the Date part of the DateTime with the DatePart of the NullDate ( this avoids subtle time differences )
                if (Convert.ToDateTime(objField).Date == NullDate.Date | Convert.ToDateTime(objField).Date == System.DateTime.MinValue | Convert.ToDateTime(objField).Date == System.DateTime.MaxValue)
                {
                    functionReturnValue = objDBNull;
                }
            }
            else if (objField is string)
            {
                if (objField == null)
                {
                    functionReturnValue = objDBNull;
                }
                else
                {
                    if (objField.ToString() == NullString)
                    {
                        functionReturnValue = objDBNull;
                    }
                }
            }
            else if (objField is bool)
            {
                if (Convert.ToBoolean(objField) == NullBoolean)
                {
                    functionReturnValue = objDBNull;
                }
            }
            else if (objField is Guid)
            {
                if (((System.Guid)objField).Equals(NullGuid))
                {
                    functionReturnValue = objDBNull;
                }
            }
            return functionReturnValue;
        }

        // checks if a field contains an application encoded null value
        public static bool IsNull(object objField)
        {
            bool functionReturnValue = false;
            if ((objField != null))
            {
                if (objField is int)
                {
                    functionReturnValue = objField.Equals(NullInteger);
                }
                else if (objField is short)
                {
                    functionReturnValue = objField.Equals(NullShort);
                }
                else if (objField is long)
                {
                    functionReturnValue = objField.Equals(NullLong);
                }
                else if (objField is float)
                {
                    functionReturnValue = objField.Equals(NullSingle);
                }
                else if (objField is double)
                {
                    functionReturnValue = objField.Equals(NullDouble);
                }
                else if (objField is decimal)
                {
                    functionReturnValue = objField.Equals(NullDecimal);
                }
                else if (objField is System.DateTime)
                {
                    DateTime objDate = (DateTime)objField;
                    functionReturnValue = objDate.Date.Equals(NullDate.Date);
                }
                else if (objField is string)
                {
                    functionReturnValue = objField.Equals(NullString);
                }
                else if (objField is bool)
                {
                    functionReturnValue = objField.Equals(NullBoolean);
                }
                else if (objField is Guid)
                {
                    functionReturnValue = objField.Equals(NullGuid);
                }
                else if (objField is DBNull)
                {
                    functionReturnValue = true;
                    // complex object
                }
                else
                {
                    functionReturnValue = false;
                }
            }
            else
            {
                functionReturnValue = true;
            }
            return functionReturnValue;
        }

    }
}
