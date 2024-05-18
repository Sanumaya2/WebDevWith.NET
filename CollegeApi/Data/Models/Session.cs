using System.Data;
using System.Formats.Asn1;

public class Session
{
    public int id {get ; set;}
     public string Title{get ; set;} = "";
      public string? Details {get ; set;}
       public DateTime Start {get ; set;}
       public float DurationInHours {get ; set;}
       public int? CourseId {get ; set ;} //fk always made in mini side or secondary table
       public Course? Course {get ; set ;} //navigation property
       
}

//Course has multiple session=one to many 
// 
// class A 
// {

// }
// class B 
// {
//     // A a = new();    //tight coupling , hard coupling
//     //Dependency injection
//     //most common: constructor injection
//     A a1;
//     public B(A a2)
//     {
//         a1 = a2;
//     }
// }
// class C 
// {

// }