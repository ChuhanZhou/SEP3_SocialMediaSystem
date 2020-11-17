package com.example.SEP3_Database.jdbc;

import com.example.SEP3_Database.model.domain.list.userList.FriendSettingList;
import com.example.SEP3_Database.model.domain.unit.user.Account;
import com.example.SEP3_Database.model.domain.unit.user.Birthday;
import com.example.SEP3_Database.model.domain.unit.user.FriendSetting;
import com.example.SEP3_Database.model.domain.unit.user.UserStatus;

import java.util.ArrayList;

public interface JDBC_interface {
    public boolean init();
    public void DeleteDatabase();
    public void CreateDataBase();
    public void insertUserInTable(Account account);
    public void UpdateDataBaseInUserTable(Account account);
    public void GetAllUserData();
    public Account getAccount(String id);
    public ArrayList<Account> getAccountList();
}

//class interfacetest {
//
//    public static void main(String[] args) {
//        Jdbc_User jdbc = new Jdbc_User();
//        System.out.println(jdbc.init());
//       // jdbc.GetAllUserData();
//       // jdbc.DeleteDatabase();
//       // jdbc.CreateDataBase();
//
//        //jdbc.getAccount("a1");
//        //System.out.println(jdbc.getAccount("a1").getId()+" :DATA>>>"+jdbc.getAccount("a1").getUserName()+"PS>>>"+jdbc.getAccount("a1").getPasswordForDataBase());
//        //System.out.println(jdbc.getAccount("a1").getFriendSettingList().getFriendSettingByIndex(0));
//       // Birthday birthday = new Birthday(11, 2);
//       // //  //jdbc.GetUserData("a5");
//       // //  System.out.println("_________________");
//       // UserStatus userStatus = new UserStatus();
//       // userStatus.setStatus("online");
//       // FriendSetting friendSetting = new FriendSetting("a2","asdsds",true);
//       // FriendSetting friendSetting2 = new FriendSetting("a3","fdafdf",false);
//       // FriendSetting friendSetting3 = new FriendSetting("a4","asdfdas",false);
//       // FriendSettingList friendSettingList = new FriendSettingList();
//       // friendSettingList.addNewFriendSetting(friendSetting);
//       // friendSettingList.addNewFriendSetting(friendSetting2);
//       // friendSettingList.addNewFriendSetting(friendSetting3);
//       // Account account = new Account("a1","asas","asas");
//       // account.setUserStatus(userStatus);
//       // account.setBirthday(birthday);
//       // account.setFriendSettingList(friendSettingList);
//       // account.setGender('F');
//       // account.setHometown("Beijing");
//       // account.setPhoneNumber(12121212);
//       // Account account11 = new Account("a3","asasasdasd","asas");
//       // account11.setUserStatus(userStatus);
//       // account11.setBirthday(birthday);
//       // account11.setFriendSettingList(friendSettingList);
//       // account11.setGender('F');
//       // account11.setHometown("Beijing");
//       // account11.setPhoneNumber(12121212);
//       // jdbc.insertUserInTable(account11);
//        //jdbc.UpdateDataBaseInUserTable(account);
//        System.out.println(jdbc.getAccountList().size()+"++++++++++++++++++++++++++++++++++");
//        System.out.println(jdbc.getAccountList().get(0).getUserName()+jdbc.getAccountList().get(1).getUserName()+jdbc.getAccountList().get(2).getUserName()+"???????????????????????????????????????????????????????????????");
//        //System.out.println(jdbc.getUserRemain()+"/"+jdbc.getUserPure());
//        jdbc.GetUserPureData("a1");
//        System.out.println(jdbc.getAccount("a1").getUserName()+jdbc.getAccount("a1").getPassword()+jdbc.getAccount("a1").getBirthday().getDay()+jdbc.getAccount("a1").getBirthday().getMonth()+jdbc.getAccount("a1").getGender()+jdbc.getAccount("a1").getHometown()+jdbc.getAccount("a1").getPhoneNumber()+jdbc.getAccount("a1").getFriendSettingList().getSize()+jdbc.getAccount("a1").getUserStatus().getStatus());
//        //jdbc.UpdateDataBase("a5","UserDemo5","123445",birthday);
//        // jdbc.DeleteDatabase();
//        //jdbc.CreateDataBase();
//        //jdbc.GetAllUserData();
//        // jdbc.GetUserData("a1");
//        //Account account = new Account("a6", "UserA6", "1212126");
//        //Birthday birthday = new Birthday(1,9);
//        //account.setBirthday(birthday);
//        //jdbc.insertUserInTable(account);
//        // System.out.println(jdbc.getUserPure().getId());
//        //jdbc.GetUserData("a6");
//    }
//}