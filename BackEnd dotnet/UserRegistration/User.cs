namespace User;

public class UserRegistration{
    

    public event Handler NotifyByEmail;
    public string? Name {get;set;}
    public int Id{get;set;}
    public string? password{get;set;}

    public UserRegistration(string name,int id,string pswd){
        this.Name=name;
        this.Id=id;
        this.password=pswd;
    }
    public void NewUserRegistration()
    {
        NotifyByEmail();
    }
    
   
}

    
}