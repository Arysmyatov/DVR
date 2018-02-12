using System.Collections.Generic;
using System.Linq;
using DVR.Models;

namespace DVR.Constants
{

    public static class TagGroups
    {
        public static IEnumerable<TagGroup> GetAllTaggGroups()
        {
            return new TagGroup[] {

                new TagGroup {
                    Name = "Architecture",
                    TagDescriptions = new TagDescription[] {
                        new TagDescription  {
                            Name = "Design Patterns",
                            Technologies = new string[] { "Design Patterns"}
                        },

                        new TagDescription  {
                            Name = "RESTful API",
                            Technologies = new string[] { "RESTful"}
                        },
                        new TagDescription  {
                            Name = "SOA",
                            Technologies = new string[] { "SOA architecture"}
                        },
                        new TagDescription  {
                            Name = "microservices",
                            Technologies = new string[] { "microservices"}
                        },
                        new TagDescription  {
                            Name = "SPA(Single Page Application)",
                            Technologies = new string[] { "SPA application", "Single Page Application", "Single-Page Application"}
                        },
                        new TagDescription  {
                            Name = "CQRS",
                            Technologies = new string[] { "CQRS"}
                        },
                        new TagDescription  {
                            Name = "DDD",
                            Technologies = new string[] { "DDD"}
                        },
                        new TagDescription  {
                            Name = "BDD",
                            Technologies = new string[] { "BDD"}
                        },
                        new TagDescription  {
                            Name = "OOA&D",
                            Technologies = new string[] { "OOA"}
                        },
                        new TagDescription  {
                            Name = "TDD",
                            Technologies = new string[] { "TDD"}
                        },
                        new TagDescription  {
                            Name = "SOLID",
                            Technologies = new string[] { "SOLID principles"}
                        },
                        new TagDescription  {
                            Name = "Machine Learning",
                            Technologies = new string[] { "Machine Learning"}
                        },
                        new TagDescription  {
                            Name = "Big Data",
                            Technologies = new string[] { "Big Data"}
                        },
                        new TagDescription  {
                            Name = "Windows Azure",
                            Technologies = new string[] { "Windows Azure"}
                        },
                        new TagDescription  {
                            Name = "Amazon AWS",
                            Technologies = new string[] { "Amazon AWS"}
                        }
                    }
                },

                new TagGroup {
                    Name = "BE",
                    TagDescriptions = new TagDescription[] {

                        new TagDescription  {
                            Name = "ASP.NET MVC",
                            Technologies = new string[] { "ASP .NET MVC", "ASP.NET MVC", "MVC"}
                        },
                        new TagDescription  {
                            Name = ".Net Core",
                            Technologies = new string[] { ".Net Core" }
                        },
                        new TagDescription  {
                            Name = "ASP.NET Web API",
                            Technologies = new string[] { "ASP.NET Web API",
                                            "Web API",
                                            "Web API",
                                            "WEB.API"
                            }
                        },
                        new TagDescription  {
                            Name = "WPF",
                            Technologies = new string[] { "WPF" }
                        },
                        new TagDescription  {
                            Name = "WCF",
                            Technologies = new string[] { "WCF" }
                        },
                        new TagDescription  {
                            Name = "XML/XSL",
                            Technologies = new string[] { "XML/XSL",
                                                            "XML",
                                                            "XSL"
                            }
                        },
                        new TagDescription  {
                            Name = "N-Hibernate",
                            Technologies = new string[] { "N-Hibernate",
                                                        "NHibernate",
                                                        "Hibernate"
                            }
                        },
                        new TagDescription  {
                            Name = "Entity Framework",
                            Technologies = new string[] { "Entity Framework",
                                                            "EntityFramework" }
                        },
                        new TagDescription  {
                            Name = "ADO.NET",
                            Technologies = new string[] { "ADO.NET" }
                        },
                        new TagDescription  {
                            Name = "Rabbit MQ",
                            Technologies = new string[] { "Rabbit MQ",
                                                        "RabbitMQ" }
                        },
                        new TagDescription  {
                            Name = "Elastic Search",
                            Technologies = new string[] { "Elastic Search",
                                                        "ElasticSearch" }
                        },
                        new TagDescription  {
                            Name = "Message Queue",
                            Technologies = new string[] { "Message Queue",
                                                        "MessageQueue" }
                        },
                        new TagDescription  {
                            Name = "TPL",
                            Technologies = new string[] { "TPL" }
                        },
                        new TagDescription  {
                            Name = "Redis",
                            Technologies = new string[] { "Redis" }
                        },
                        new TagDescription  {
                            Name = "NServiceBus",
                            Technologies = new string[] { "NServiceBus",
                                                        "ServiceBus" }
                        }
                    }
                },

                new TagGroup {
                    Name = "FE",
                    TagDescriptions = new TagDescription[] {
                        new TagDescription  {
                            Name = "JavaScript",
                            Technologies = new string[] { "JavaScript", "JScript", "Vanilla JS", "VanillaJS" }
                        },
                        new TagDescription  {
                            Name = "ECMAScript 6",
                            Technologies = new string[] { "ECMAScript 6", "ECMAScript6"}
                        },
                        new TagDescription  {
                            Name = "TypeScript",
                            Technologies = new string[] { "TypeScript"}
                        },
                        new TagDescription  {
                            Name = "JQuery",
                            Technologies = new string[] { "JQuery"}
                        },
                        new TagDescription  {
                            Name = "jQuery UI",
                            Technologies = new string[] { "jQuery UI", "jQueryUI"}
                        },
                        new TagDescription  {
                            Name = "Kendo UI",
                            Technologies = new string[] { "Kendo UI", "KendoUI"}
                        },
                        new TagDescription  {
                            Name = "AngularJS",
                            Technologies = new string[] { "Angular"}
                        },
                        new TagDescription  {
                            Name = "ReactJS",
                            Technologies = new string[] { "ReactJS", "React JS" }
                        },
                        new TagDescription  {
                            Name = "VUE.js",
                            Technologies = new string[] { "VUE.js"}
                        },
                        new TagDescription  {
                            Name = "KnockoutJs",
                            Technologies = new string[] { "Knockout"}
                        },
                        new TagDescription  {
                            Name = "Bootstrap",
                            Technologies = new string[] { "Bootstrap"}
                        },
                        new TagDescription  {
                            Name = "JSON",
                            Technologies = new string[] { "JSON"}
                        },
                        new TagDescription  {
                            Name = "HTML5",
                            Technologies = new string[] { "HTML5"}
                        },
                        new TagDescription  {
                            Name = "AJAX",
                            Technologies = new string[] { "AJAX"}
                        },
                        new TagDescription  {
                            Name = "ReactiveUI",
                            Technologies = new string[] { "ReactiveUI"}
                        },
                        new TagDescription  {
                            Name = "Webpack",
                            Technologies = new string[] { "Webpack"}
                        },
                        new TagDescription  {
                            Name = "AMD CommonJS UMD",
                            Technologies = new string[] { "AMD CommonJS UMD", "AMD", "UMD"}
                        }
                    }
                },

                new TagGroup {
                    Name = "DataBase",
                    TagDescriptions = new TagDescription[] {
                        new TagDescription  {
                            Name = "MS SQL Server",
                            Technologies = new string[] { "SQLServer", "SQL Server" }
                        },
                        new TagDescription  {
                            Name = "SQL, Transact SQL",
                            Technologies = new string[] {"SQL", "T-SQL" }
                        },
                        new TagDescription  {
                            Name = "RavenDB",
                            Technologies = new string[] { "RavenDB", "Raven DB", "Raven" }
                        },
                        new TagDescription  {
                            Name = "NoSQL",
                            Technologies = new string[] { "NoSQL", "No SQL" }
                        },
                        new TagDescription  {
                            Name = "Mongo DB",
                            Technologies = new string[] { "Mongo" }
                        },
                        new TagDescription  {
                            Name = "Cassandra",
                            Technologies = new string[] { "Cassandra" }
                        },
                        new TagDescription  {
                            Name = "PostgreSQL DB",
                            Technologies = new string[] { "Postgre" }
                        },
                        new TagDescription  {
                            Name = "DynamoDB",
                            Technologies = new string[] { "DynamoDB" }
                        }
                    }
                },

                new TagGroup {
                    Name = "Architecture",
                    TagDescriptions = new TagDescription[] {
                        new TagDescription  {
                            Name = "Moq",
                            Technologies = new string[] { "Moq" }
                        },
                        new TagDescription  {
                            Name = "NUnit",
                            Technologies = new string[] { "NUnit" }
                        },
                        new TagDescription  {
                            Name = "NSpec",
                            Technologies = new string[] { "NSpec" }
                        },
                        new TagDescription  {
                            Name = "Jasmine",
                            Technologies = new string[] { "Jasmine" }
                        }
                    }
                }
                
            };
        }
    }


    public static class TagDescriptions
    {
        public static IEnumerable<TagDescription> GetAllTagDescriptions()
        {
            var allGroups = TagGroups.GetAllTaggGroups().SelectMany(g => g.TagDescriptions);
            return allGroups;
        }
    }
}