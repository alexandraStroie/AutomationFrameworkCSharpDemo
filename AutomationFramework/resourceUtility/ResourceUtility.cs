using System.Reflection;
using System.Resources;

namespace AutomationFramework.resourceUtility
{
    public class ResourceUtility
    {
        public ResourceManager Resource { get; private set; }

        public ResourceUtility(string path)
        {
            Resource = new ResourceManager($"AutomationFramework.resources.{path}", Assembly.GetExecutingAssembly());

        }

        public string GetValue(string key) 
        {
            return Resource.GetString(key);
        }
    }
}
