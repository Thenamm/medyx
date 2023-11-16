using System;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Telerik.Web.UI;
namespace Telerik.Mvc.Web.Helpers
{
    /// <summary>
    /// Extensions for working with Telerik UI in ASP.NET AJAX
    /// </summary>
    public static class RadControlHelper
    {
        /// <summary>
        /// Returns the HTML content posted by specific RadEditor instance
        /// </summary>
        /// <param name="request">The current request</param>
        /// <param name="editorId">The ID of the RadEditor (the value of the ID property)</param>
        public static string ExtractHtmlValue(HttpRequestBase request, string editorId)
        {
            return Telerik.Web.UI.Editor.ContentEncoder.Decode(ExtractStringValue(request, editorId));
        }
        /// <summary>
        /// Returns a DateTime object representing the value of a specified RadDatePicker
        /// </summary>
        /// <param name="request">The current request</param>
        /// <param name="dateControlId">The ID of the control (RadDatePicker, RadDateInput)</param>
        /// <returns>
        ///  A <see cref="DateTime"/> representing the value of the specified control. <see cref="DateTime.MinValue"/>
        /// if the specified control is empty.
        /// </returns>
        public static DateTime ExtractDateValue(HttpRequestBase request, string dateControlId)
        {
            var dateAsString = ExtractStringValue(request, dateControlId);
            DateTime value = DateTime.MinValue;
            if (!DateTime.TryParse(dateAsString, out value))
            {
                DateTime.TryParseExact(dateAsString, "yyyy-MM-dd-HH-mm-ss",
                 DateTimeFormatInfo.InvariantInfo,
                 DateTimeStyles.None,
                 out value);
            }
            return value;
        }
        /// <summary>
        /// Returns the value of the selected item in the specified RadComboBox
        /// </summary>
        /// <param name="request">The current request</param>
        /// <param name="comboboxId">The ID of the RadComboBox</param>
        /// <returns>A <see cref="String"/> representing the selected value of the RadComboBox</returns>
        public static string ExtractComboBoxValue(HttpRequestBase request, string comboboxId)
        {
            var clientStateString = ExtractStringValue(request, comboboxId + "_ClientState");
            var clientState = new JavaScriptSerializer().Deserialize<RadComboBoxClientState>(clientStateString);
            return clientState.Value;
        }
        /// <summary>
        /// Returns the posted value of server side control.
        /// </summary>
        /// <param name="request">The current request</param>
        /// <param name="controlId">The value of the server-side ID property</param>
        public static string ExtractStringValue(HttpRequestBase request, string controlId)
        {
            return request.Form.Keys.OfType<string>()
             .Where(postedValue => postedValue.EndsWith(controlId))
             .Select(postedValue => request.Form[postedValue])
             .FirstOrDefault();
        }
    }
}