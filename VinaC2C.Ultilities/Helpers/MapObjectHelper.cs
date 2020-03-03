using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace VinaC2C.Ultilities.Helpers
{
    public  class MapObjectHelper
    {
        public static void MapDefault<Tin,Tout>(Tin input, out Tout output)
        {
            output = Activator.CreateInstance<Tout>();
            if(input != null && output != null)
            {
                List<PropertyInfo> inputProperties = input.GetType().GetProperties().ToList<PropertyInfo>();
                List<PropertyInfo> outputProperties = output.GetType().GetProperties().ToList<PropertyInfo>();
                foreach (PropertyInfo inputProperty in inputProperties)
                {
                    PropertyInfo destinationProperty = outputProperties.Find(item => item.Name == inputProperty.Name);

                    if (destinationProperty != null)
                    {
                        try
                        {
                            destinationProperty.SetValue(output, inputProperty.GetValue(input, null), null);
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
        }
    }
}
