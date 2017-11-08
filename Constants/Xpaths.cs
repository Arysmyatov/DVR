namespace DVR.Constants
{
    public static class Xpaths
    {
        public const string VacancyUrl = @"//*[@id='vacancyListId']/ul/li/div/div/a";
        public const string CompanyName = @"//*[@class='b-compinfo']/div/div[1]/a[1]";
        public const string CompanyDescription = @"//*[@class='b-compinfo']/div/div[1]/a[2]";
        public const string Position = @"//*[@class='b-compinfo']/h1";        
        public const string Vacancy = @"//*[@class='vacancy-section']";
        public const string AboutProject = @"//*[@class='project']";        
    }
}