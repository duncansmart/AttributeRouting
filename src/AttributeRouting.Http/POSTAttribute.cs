namespace AttributeRouting.Http
{
    public class POSTAttribute : HttpRouteAttribute {
        public POSTAttribute(string routeUrl)
            : base(routeUrl, "POST")
        {
            
        }
    }
}