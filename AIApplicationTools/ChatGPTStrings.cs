public class CONSTANTS
{
    public const string ResumeObjectCode = """
        class Resume
        {
            string name = "";
            string email = "";
            string phone = "";
            string address = "";
            string website = "";
        
            List<Education> educations = new List<Education>();
            List<Experience> experiences = new List<Experience>();
            List<Project> projects = new List<Project>();
        
            public Resume()
            { }
            
            public Resume(string name, string email, string phone, string address, string website, List<Education> educations, List<Experience> experiences, List<Project>projects)
            {
                this.name = name;
                this.email = email;
                this.phone = phone;
                this.address = address;
                this.website = website;
                this.educations = educations;
                this.experiences = experiences;
                this.projects = projects;
            }
         }

        class Education
        {
            string school = "";
            string degree = "";
            string major = "";
            string startDate = "";
            string graduationDate = "";
        
            public Education(string school, string degree, string major, string startDate, string graduationDate)
            {
                this.school = school;
                this.degree = degree;
                this.major = major;
                this.startDate = startDate;
                this.graduationDate = graduationDate;
            }
        }
        
        class Experience
        {
            string position = "",
                company = "",
                startingDate = "",
                endingDate = "",
                description = "";
        
            public Experience(string position, string company, string startingDate, string endingDate, string description)
            {
                this.position = position;
                this.company = company;
                this.startingDate = startingDate;
                this.endingDate = endingDate;
                this.description = description;
            }
        }
        
        class Project
        {
            string name = "",
                startingDate = "",
                endingDate = "",
                subtitle = "",
                description = "";
        
            public Project(string name, string startingDate, string endingDate, string subtitle, string description)
            {
                this.name = name;
                this.startingDate = startingDate;
                this.endingDate = endingDate;
                this.subtitle = subtitle;
                this.description = description;
            }
        }
        """;

    public const string OutputFormat = """
        Read the PDF and ouptut a summary of the resume in the following format:
        Name: [Name]
        Email: [Email]
        Phone: [Phone]
        Address: [Address]
        Website: [Website]
        LinkedIn: [LinkedIn]

        Section Start: Education
        School: [School]
        Degree: [Degree]
        Major: [Major]
        Start Date: [Start Date]
        Graduation Date: [Graduation Date]
        Section End: Education

        Section Start: Experience
        Position [#]
        Position: [Position]
        Company: [Company]
        Start Date: [Start Date]
        End Date: [End Date]
        Description: [Description]
        Section End: Experience

        Section Start: Project
        Project [#]
        Name: [Name]
        Start Date: [Start Date]
        End Date: [End Date]
        Subtitle: [Subtitle]
        Description: [Description]
        Section End: Project
            
        Miscellaneous: [Miscellaneous]
        End Of Resume

        If you need to add more sections
        Increment the Position Number and add the section
        When the end of the section is over, put the Section End tag
        If a field is not detexted, there is no need to return it.
        If a section is not detected, there is no need to return it.
        Do not modify the format of the fields read.
        Do not change the text that is read from the PDF.
        Keep all words and punctuation as is.
        Transfer the text from the read pdf to the output format with no changes.

        Here is the PDF Resume in Text Format:
        """;
}
