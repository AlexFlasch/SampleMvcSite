using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMvcSite.Models
{
    /*
     * Here's a model. A model is basically used to pass data from your controller to your view.
     * Generally all that will be here are some properties that the view may need. For example:
     * That variable that's shown on the Home view is set by the controller, stored here, and
     * passed from the model to the view. Pretty simple stuff!
     */
    public class HomeModel
    {
        /*
         * This is a property in C#. Its essentially the same as public String someRandomString; in Java,
         * but this wonderful thing makes a default getter and setter for the field. The get; and set; allow you to use
         * different actions depending on if you're setting the property or getting it.
         * 
         *      Previous to getting or setting a property you must instantiate the class it is in, exactly like Java:
         *          HomeModel model = new HomeModel();
         * 
         *      To access a property it would just be string theString = model.someRandomString;
         *      To set a property, as you might expect, it is model.someRandomString = "some random value";
         * 
         *  (note the casing on the methods. In C# it is standard to use PascalCase rather than camelCase for methods, 
         *   properties and events. camelCase is used for variables though, so that hasn't changed.)
         */
        public string someRandomString { get; set; }
    }
}