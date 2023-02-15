using System;

public class Database
{
  
  private string Message{ get; set; }
  private Guid MessageGuid{get;set;}

  public string writeToMongo(string textToWrite){
    upDateMessage(textToWrite);
    return "${textToWrite} has been written to mongo";
  }

  public string readFromMongo(Guid entryId){
    return "found";
  }

  public void upDateMessage(string newMessage){
    Message = newMessage; 
  }
    
}
