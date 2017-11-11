using System.Collections.Generic;
using DVR.Models;

namespace DVR.Constants
{
    public static class TagDescriptions
    {
        public static IEnumerable<TagDescription> GetAllTagDescriptions()
        {
            return new TagDescription[] {
                    new TagDescription {
                        Name = "Design Patterns",
                        Technologies = new string[] { "Design Patterns"}
                    },
                    new TagDescription {
                        Name = "RESTful API",
                        Technologies = new string[] { "RESTful"}
                    },
                    new TagDescription {
                        Name = "microservices",
                        Technologies = new string[] { "microservices"}
                    },
                    new TagDescription {
                        Name = "SPA(Single Page Application)",
                        Technologies = new string[] { "SPA ", "Single Page Application", "Single-Page Application"}
                    },
                    new TagDescription {
                        Name = "CQRS",
                        Technologies = new string[] { "CQRS"}
                    },
                    new TagDescription {
                        Name = "TDD",
                        Technologies = new string[] { "TDD"}
                    },
                    new TagDescription {
                        Name = "SOLID",
                        Technologies = new string[] { "SOLID"}
                    },
                    new TagDescription {
                        Name = ".Net Core",
                        Technologies = new string[] { "Net Core", "NetCore", "ASP.NET Core", "ASP .NET Core",  "dotent core", "dotnetcore"}
                    },
                    new TagDescription {
                        Name = "TypeScript",
                        Technologies = new string[] { "TypeScript"}
                    },
                    new TagDescription {
                        Name = "ASP.NET Web API",
                        Technologies = new string[] { "ASP.NET Web API",
                                        "Web API",
                                        "Web API",
                                        "WEB.API"
                        }
                    },
                    new TagDescription {
                        Name = "AngularJS",
                        Technologies = new string[] { "Angular"}
                    },
                    new TagDescription {
                        Name = "ASP.NET MVC",
                        Technologies = new string[] { "ASP .NET MVC", "ASP.NET MVC", "MVC"}
                    },
                    new TagDescription {
                        Name = "ReactJS",
                        Technologies = new string[] { "ReactJS", "React JS" }
                    }
                };
        }
    }
}