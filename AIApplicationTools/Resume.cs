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

    public override string ToString()
    {
        string Text = "";
        Text += "Name: " + name + "\n";
        Text += "Email: " + email + "\n";
        Text += "Phone: " + phone + "\n";
        Text += "Address: " + address + "\n";
        Text += "Website: " + website + "\n";
        Text += "Educations: \n";
        foreach (var education in educations)
        {
            Text += education.ToString() + "\n";
        }
        Text += "Experiences: \n";
        foreach (var experience in experiences)
        {
            Text += experience.ToString() + "\n";
        }
        Text += "Projects: \n";
        foreach (var project in projects)
        {
            Text += project.ToString() + "\n";
        }
        return Text;
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

    public override string ToString()
    {
        string Text = "";
        Text += "School: " + school + "\n";
        Text += "Degree: " + degree + "\n";
        Text += "Major: " + major + "\n";
        Text += "Start Date: " + startDate + "\n";
        Text += "Graduation Date: " + graduationDate + "\n";
        return Text;
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
    public override string ToString()
    {
        string Text = "";
        Text += "Position: " + position + "\n";
        Text += "Company: " + company + "\n";
        Text += "Starting Date: " + startingDate + "\n";
        Text += "Ending Date: " + endingDate + "\n";
        Text += "Description: " + description + "\n";
        return Text;
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

    public override string ToString()
    {
        string Text = "";
        Text += "Name: " + name + "\n";
        Text += "Starting Date: " + startingDate + "\n";
        Text += "Ending Date: " + endingDate + "\n";
        Text += "Subtitle: " + subtitle + "\n";
        Text += "Description: " + description + "\n";
        return Text;
    }
}
