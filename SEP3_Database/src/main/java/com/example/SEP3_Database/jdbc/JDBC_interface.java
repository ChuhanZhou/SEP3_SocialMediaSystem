package com.example.SEP3_Database.jdbc;

public interface JDBC_interface {
    public boolean init();

    public void GetAllUserData();

    public String getId();

    public int getUserD();

    public int getUserM();

    public String getUserName();

    public String getUserPassword();
    // public void generateM(int BM);
    // public void generateD(int BD);
    // public DateClassConvert getDate();
    // public void assemble();

}

class interfacetest {

    public static void main(String[] args) {
        Jdbc jdbc = new Jdbc();
        System.out.println(jdbc.init());
        jdbc.GetAllUserData();
        jdbc.getAccount("a1");
        System.out.println(jdbc.getAccount("a1").getId()+" :DATA>>>"+jdbc.getAccount("a1").getUserName()+"PS>>>"+jdbc.getAccount("a1").getPasswordForDataBase());
        System.out.println(jdbc.getAccount("a1").getFriendSettingList().getFriendSettingByIndex(0));
      //  Birthday birthday = new Birthday(11, 2);
      //  //jdbc.GetUserData("a5");
      //  System.out.println("_________________");
      //  UserStatus userStatus = new UserStatus();
      //  userStatus.setStatus("online");
      //  FriendSetting friendSetting = new FriendSetting("a2","isa",true);
      //  FriendSetting friendSetting2 = new FriendSetting("a3","isaccc",false);
      //  FriendSetting friendSetting3 = new FriendSetting("a4","isacccddd",false);
      //  FriendSettingList friendSettingList = new FriendSettingList();
      //  friendSettingList.addNewFriendSetting(friendSetting);
      //  friendSettingList.addNewFriendSetting(friendSetting2);
      //  friendSettingList.addNewFriendSetting(friendSetting3);
      //  Account account = new Account("a1","Isaac","1234567");
      //  account.setUserStatus(userStatus);
      //  account.setBirthday(birthday);
      //  account.setFriendSettingList(friendSettingList);
      //  jdbc.insertUserInTable(account);
      //  System.out.println(jdbc.getUserRemain()+"/"+jdbc.getUserPure());
        jdbc.GetUserPureData("a1");
        //jdbc.UpdateDataBase("a5","UserDemo5","123445",birthday);
        // jdbc.DeleteDatabase();
        //jdbc.CreateDataBase();
        //jdbc.GetAllUserData();
        // jdbc.GetUserData("a1");
        //Account account = new Account("a6", "UserA6", "1212126");
        //Birthday birthday = new Birthday(1,9);
        //account.setBirthday(birthday);
        //jdbc.insertUserInTable(account);
        // System.out.println(jdbc.getUserPure().getId());
        //jdbc.GetUserData("a6");
    }
}