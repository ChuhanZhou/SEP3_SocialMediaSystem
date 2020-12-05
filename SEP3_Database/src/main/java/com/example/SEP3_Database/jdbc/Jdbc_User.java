package com.example.SEP3_Database.jdbc;

import java.lang.reflect.Type;
import java.sql.*;
import java.util.ArrayList;
import java.util.Scanner;

import com.example.SEP3_Database.model.domain.list.message.GroupMessageList;
import com.example.SEP3_Database.model.domain.list.message.PrivateMessageList;
import com.example.SEP3_Database.model.domain.unit.message.PrivateMessage;
import com.example.SEP3_Database.model.domain.unit.time.MyTime;
import org.joda.time.DateTime;
import com.example.SEP3_Database.model.domain.list.groupList.ChatGroupList;
import com.example.SEP3_Database.model.domain.list.userList.FriendSettingList;
import com.example.SEP3_Database.model.domain.unit.group.ChatGroup;
import com.example.SEP3_Database.model.domain.unit.message.GroupMessage;
import com.example.SEP3_Database.model.domain.unit.message.MessageType;
import com.example.SEP3_Database.model.domain.unit.user.*;
import com.google.gson.Gson;
import com.google.gson.reflect.TypeToken;

public class Jdbc_User implements JDBC_interface {
    //Account ATTs
    private Account account;
    private static final String JDBC_DRIVER = "com.mysql.cj.jdbc.Driver";
    private String id;
    private String userName;
    private String userPassword;
    private int userM;
    private int userD;
    private Statement stmt = null;
    private Statement stmt2 = null;
    private Statement stmt3 = null;
    private Statement stmt4 = null;
    private Statement stmt5 = null;
    private char gender;
    private String hometown;
    private long phonenumber;
    String mo;
    String da;
    DateClassConvert Date = new DateClassConvert("", "");
    private Scanner scanner = new Scanner(System.in);
    private String executeSQL = "";
    private UserPure userPure = new UserPure("", "", null, "", ' ', "", -1);
    private UserRemain userRemain = new UserRemain("", null, null);
    private Birthday birthday;
    private String idf;
    private String usernamef;
    private String passwordf;
    private Birthday birthdayf;
    private String hometownf;
    private char genderf;
    private long phonenumberf;
    private int D;
    private int M;
    private FriendSettingList FSL;
    private UserStatus USS;
    //3——5 ATTs
    private Gson gson = new Gson();
    private ArrayList<String> idList = new ArrayList<>();
    private String GroupId;
    private String FoundId;
    private String GroupName;
    private ChatGroupList chatGroupList = new ChatGroupList();
    private String GMGroupId;
    private String MessageInfo;
    private MessageType messageType;
    private String GMSenderId;
    private MyTime time;
    private GroupMessageList groupMessageList = new GroupMessageList();
    private String ReceiverId;
    private String SenderId;
    private String PMessageInfo;
    private MessageType pMessageType;
    private MyTime pTime;
    private PrivateMessageList privateMessageList = new PrivateMessageList();

    //数据库连接方法
    public boolean init() {
        try {
            Class.forName(JDBC_DRIVER);
            System.out.println("DataBaseDriveLoaded");
            String username = "root";
            String password = "0811";
            String dbUrl = "jdbc:mysql://localhost:3306/sep3_local?useSSL=false&allowPublicKeyRetrieval=true&serverTimezone=UTC";
            Connection conn = DriverManager.getConnection(dbUrl, username, password);
            System.out.println(">>Sql connected<<");
            System.out.println(">>Link To SQL: " + dbUrl + " <<<");
            System.out.println(">>User And Password: " + username + "///" + password + " <<<");
            stmt = conn.createStatement();
            stmt2 = conn.createStatement();
            System.out.println(">>System Activated. Database all good<<");
            return true;
        } catch (Exception e) {
            System.out.println(e + "_____________________");
            return false;
        }
    }

    //删库+跑路
    public void DeleteDatabase() {
        System.out.println(">>>DeleteDatabase Begin<<<");
        System.out.println("Do you want to delete your database? (Y?N)");
        String a = scanner.nextLine();
        if (a.equals("Y") || a.equals("y")) {
            try {
                executeSQL = "Drop Table UserTable";
                stmt.executeUpdate(executeSQL);
                System.out.println("---T1 Successful");
                executeSQL = "Drop Table UserSettingTable";
                stmt.executeUpdate(executeSQL);
                System.out.println("---T2 Successful");
                executeSQL = "Drop Table chatgrouptable";
                stmt.executeUpdate(executeSQL);
                System.out.println("---T3 Successful");
                executeSQL = "Drop Table groupmessagetable";
                stmt.executeUpdate(executeSQL);
                System.out.println("---T4 Successful");
                executeSQL = "Drop Table privatemessagetable";
                stmt.executeUpdate(executeSQL);
                System.out.println("---T5 Successful");
                System.out.println(">>>Whole DataBase delete successful<<<");
            } catch (Exception e) {
                e.printStackTrace();
            }
        } else {
            System.out.println("You have exited the delete function");
        }
    }

    //创建数据库
    public void CreateDataBase() {
        System.out.println(">>>Database Creation Begins<<<");
        System.out.println("Do you want to Create the database? (Y?N)");
        String a = scanner.nextLine();
        if (a.equals("Y") || a.equals("y")) {
            try {
                executeSQL = "CREATE TABLE `UserSettingTable` (\n" +
                        "  `UserID` varchar(45) NOT NULL,\n" +
                        "  `FriendId` varchar(45) NOT NULL,\n" +
                        "  `UserNote` varchar(45) DEFAULT NULL,\n" +
                        "  `DisablePost` tinyint(1) NOT NULL DEFAULT '0',\n" +
                        "  `UserStatus` varchar(1000) NOT NULL\n" +
                        ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;\n";
                stmt.executeUpdate(executeSQL);
                System.out.println("T1: UserSettingTable");
                executeSQL = "CREATE TABLE `UserTable` (\n" +
                        "  `UserId` varchar(45) NOT NULL,\n" +
                        "  `UserName` varchar(100) NOT NULL,\n" +
                        "  `UserPassword` varchar(100) NOT NULL,\n" +
                        "  `BirthdayMonth` int(11) DEFAULT NULL,\n" +
                        "  `BirthdayDate` int(11) DEFAULT NULL,\n" +
                        "  `Gender` char(1),\n" +
                        "  `Hometown` varchar(50),\n" +
                        "  `PhoneNumber` long,\n" +
                        "  PRIMARY KEY (`UserId`),\n" +
                        "  UNIQUE KEY `UserId_UNIQUE` (`UserId`)\n" +
                        ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;\n";
                stmt.executeUpdate(executeSQL);
                System.out.println("T2: UserTable");
                executeSQL = "CREATE TABLE `sep3_local`.`ChatGroupTable` (\n" +
                        "  `GroupId` VARCHAR(50) NOT NULL,\n" +
                        "  `GroupName` VARCHAR(45) NOT NULL,\n" +
                        "  `CreatorId` VARCHAR(45) NOT NULL,\n" +
                        "  `AccountIdListJson` VARCHAR(1000) NOT NULL,\n" +
                        "  PRIMARY KEY (`GroupId`),\n" +
                        "  UNIQUE INDEX `GroupId_UNIQUE` (`GroupId` ASC) VISIBLE);";
                stmt.executeUpdate(executeSQL);
                System.out.println("T3: ChatGroupTable");
                executeSQL = "  CREATE TABLE `sep3_local`.`groupmessagetable` (\n" +
                        "  `GroupId` VARCHAR(45) NOT NULL,\n" +
                        "  `MessageInfo` VARCHAR(45) NULL,\n" +
                        "  `MessageType` ENUM('PRIVATE', 'GROUP') NOT NULL,\n" +
                        "  `SenderId` VARCHAR(45) NOT NULL,\n" +
                        "  `Time` DATETIME NULL,\n" +
                        "  PRIMARY KEY (`GroupId`),\n" +
                        "  UNIQUE INDEX `GroupId_UNIQUE` (`GroupId` ASC) VISIBLE);";
                stmt.executeUpdate(executeSQL);
                System.out.println("T4: GroupMessageTable");
                executeSQL = " CREATE TABLE `sep3_local`.`privatemessagetable` (\n" +
                        "  `ReceiverId` VARCHAR(45) NOT NULL,\n" +
                        "  `SenderId` VARCHAR(45) NOT NULL,\n" +
                        "  `MessageInfo` VARCHAR(45) NULL,\n" +
                        "  `MessageType` ENUM('PRIVATE', 'GROUP') NOT NULL,\n" +
                        "  `Time` DATETIME NULL,\n" +
                        "  PRIMARY KEY (`ReceiverId`));";
                stmt.executeUpdate(executeSQL);
                System.out.println("T5: PrivateMessageTable");
            } catch (Exception e) {
                e.printStackTrace();
            }
        } else System.out.println("You have exited the creation function");
    }

    //自定义
    public void setExecuteSQL(String executeSQL) throws SQLException {
        this.executeSQL = executeSQL;
        stmt.executeUpdate(executeSQL);
    }

    //分解account
    public void dissembleAccount(Account account) {
        String ida = account.getId();
        char gender = account.getGender();
        String hometown = account.getHometown();
        long phoneNumber = account.getPhoneNumber();
        String usernameA = account.getUserName();
        String passwordA = account.getPassword();
        Birthday birthdayA = account.getBirthday();
        FriendSettingList fsl = account.getFriendSettingList();
        UserStatus uss = account.getUserStatus();
        System.out.println(getUserPure().getId() + ">>>Start dissemble and set to account pure<<<");
        assemblePure(ida, usernameA, passwordA, birthdayA, gender, hometown, phoneNumber);
        System.out.println(getUserPure().getId() + ">>>Start dissemble and set to account Remain<<<");
        assembleUserRemain(ida, fsl, uss);
    }

    //组装account
    public void assemblePure(String ids, String us, String ps, Birthday br, char gender, String hometown, long phoneNumber) {
        System.out.println(getUserPure().getId() + " >>>Start to set account<<<");
        userPure.setGender(gender);
        userPure.setHometown(hometown);
        userPure.setPhoneNumber(phoneNumber);
        userPure.setId(ids);
        userPure.setBirthday(br);
        userPure.setPassword(ps);
        userPure.setUserName(us);
    }

    //组装userRemain
    public void assembleUserRemain(String id, FriendSettingList friendSettingList, UserStatus userStatus) {
        System.out.println(getUserRemain().getFriendSettingList() + " >>>Start to set Remains<<<");
        userRemain.setFriendSettingList(friendSettingList);
        userRemain.setUserStatus(userStatus);
        userRemain.setId(id);
    }

    //get方法
    public UserPure getUserPure() {
        return userPure;
    }

    public UserRemain getUserRemain() {
        return userRemain;
    }

    //组装并填入
    public void insertUserInTable(Account account) {
        try {
            dissembleAccount(account);
            System.out.println(">>>Start insert User account into Database<<<");
            executeSQL = "insert into UserTable (UserId,UserName,UserPassword,BirthdayMonth,BirthdayDate,gender,hometown,phoneNumber) values (\"" + userPure.getId() + "\",\"" + userPure.getUserName() + "\",\"" + userPure.getPassword() + "\"," + userPure.getBirthday().getMonth() + "," + userPure.getBirthday().getDay() + ",\"" + userPure.getGender() + "\",\"" + userPure.getHometown() + "\"," + userPure.getPhoneNumber() + ");";
            stmt.executeUpdate(executeSQL);
            //System.out.println(">>>Start insert into UserSettingsTable<<<");
            //stmt.executeUpdate(executeSQL);
            insertRemain(account);
            System.out.println("Insert done");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    //填入剩下的部分
    public void insertRemain(Account account) {
        try {
            System.out.println(">>>Start insert into UserSettingsTable<<<");
            //System.out.println("Friendsize="+account.getFriendSettingList().getSize()+"?????????????");
            //System.out.println("FRIENDSIZE@="+userRemain.getFriendSettingList().getSize()+"!!!!!!!!!!!!!!!");
            for (int i = 0; i < account.getFriendSettingList().getSize(); i++) {
                executeSQL = "insert into UserSettingTable(UserID,friendId,UserNote,DisablePost,UserStatus) values (\"" + userRemain.getPublicUserId() + "\",\"" + userRemain.getFriendSettingList().getFriendSettingByIndex(i).getId() + "\",\"" + userRemain.getFriendSettingList().getFriendSettingByIndex(i).getNote() + "\",\"" + TransPort(i) + "\",\"" + userRemain.getUserStatus() + "\");";
                System.out.println(executeSQL);
                stmt.executeUpdate(executeSQL);
                System.out.println("Loop " + i + " is done");
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    //pots设置
    private int TransPort(int i) {
        if (userRemain.getFriendSettingList().getFriendSettingByIndex(i).isDisablePost()) {
            return 1;
        }
        return 0;
    }

    private int TransPorta(int i, Account account) {
        if (account.getFriendSettingList().getFriendSettingByIndex(i).isDisablePost()) {
            return 1;
        }
        return 0;
    }

    //更新
    public void UpdateDataBaseInUserTable(Account account) {
        try {
            String IDF = account.getId();
            String Username = account.getUserName();
            String Password = account.getPassword();
            Birthday Birthday = account.getBirthday();
            char Genderu = account.getGender();
            String hometownU = account.getHometown();
            long phonenumberU = account.getPhoneNumber();
            System.out.println("<<<<<<<<>>>>>>>>>id>> " + IDF + "/ fn>> " + Username + "/ pn>> " + Password + "/ bm>> " + Birthday.getMonth() + "/ bd>> " + Birthday.getDay() + "/ SEX>>" + Genderu + "/ HT>>" + hometownU + "/ PN>>" + phonenumberU);
            //FriendSettingList friendSettingListU = account.getFriendSettingList();
            executeSQL = "update userTable set Username = \"" + Username + "\", UserPassword = \"" + Password + "\",BirthdayMonth = \"" + Birthday.getMonth() + "\", BirthdayDate = \"" + Birthday.getDay() + "\", gender = \"" + Genderu + "\", hometown = \"" + hometownU + "\", phoneNumber = \"" + phonenumberU + "\" where UserId = \"" + IDF + "\";";
            stmt.executeUpdate(executeSQL);
            executeSQL = "Delete from usersettingtable where userid = \"" + account.getId() + "\";";
            stmt.executeUpdate(executeSQL);
            for (int i = 0; i < account.getFriendSettingList().getSize(); i++) {
                executeSQL = "insert into UserSettingTable(UserID,friendId,UserNote,DisablePost,UserStatus) values (\"" + account.getId() + "\",\"" + account.getFriendSettingList().getFriendSettingByIndex(i).getId() + "\",\"" + account.getFriendSettingList().getFriendSettingByIndex(i).getNote() + "\",\"" + TransPorta(i, account) + "\",\"" + account.getUserStatus() + "\");";
                System.out.println(executeSQL);
                stmt.executeUpdate(executeSQL);
                System.out.println("Loop " + i + " is done");
            }
            System.out.println("Update complete");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    //string获取
    public void GetAllUserData() {
        //GetAllUserInfoIn upper String
        try {
            //executeSQL = " Select*from UserTable where userId = \""+id+"\"";
            executeSQL = " Select*from UserTable";
            ResultSet rs = stmt.executeQuery(executeSQL);
            executeSQL = "";
            while (rs.next()) {
                id = rs.getString("UserId");
                //UserIDArray.add(id);
                userName = rs.getString("UserName");
                //UserNameArray.add(userName);
                userPassword = rs.getString("UserPassword");
                //UserPasswordArray.add(userPassword);
                userM = rs.getInt("BirthdayMonth");
                userD = rs.getInt("BirthdayDate");
                gender = rs.getString("gender").charAt(0);
                System.out.println("Char:" + gender + "?" + rs.getString("gender"));
                hometown = rs.getString("hometown");
                phonenumber = rs.getLong("phonenumber");
                //birthday.set(userD,userM);
                //UserBirthdayArray.add(birthday);
                System.out.println("id>> " + id + "/ fn>> " + userName + "/ pn>> " + userPassword + "/ bm>> " + userM + "/ bd>> " + userD + "/ SEX>>" + gender + "/ HT>>" + hometown + "/ PN>>" + phonenumber);
            }
            System.out.println("Closing Data");
            reset();
            // rs.close();
            // stmt.close();
            // conn.close();
        } catch (Exception e) {
            //e.printStackTrace();
            System.out.println(e + "_____________________");
        }
    }

    //取得userRemain数据
    private UserRemain GetUserRemainData(String id) {
        FriendSettingList friendSettingListR = new FriendSettingList();
        FriendSetting friendSetting;
        //String friendID = null;
        UserStatus userStatus = new UserStatus();
        this.id = id;
        try {
            executeSQL = "select * from userSettingTable where UserId = \"" + id + "\";";
            ResultSet rs = stmt.executeQuery(executeSQL);
            executeSQL = "";
            while (rs.next()) {
                friendSetting = new FriendSetting("", "", true);
                //userStatus1.setStatus("Offline");
                userStatus.logoff();
                System.out.println(rs.getString("Userid"));
                friendSetting.setId(rs.getString("FriendId"));
                System.out.println(rs.getString("FriendId"));
                friendSetting.setNote(rs.getString("userNote"));
                System.out.println(rs.getString("userNote"));
                friendSetting.setDisablePost(rs.getBoolean("DisablePost"));
                System.out.println(rs.getBoolean("DisablePost"));
                friendSettingListR.addNewFriendSetting(friendSetting);
                System.out.println("Loop inside RS:UserRemain, count " + friendSettingListR.getSize());
                //friendID = rs.getString("FriendId");
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return new UserRemain(id, friendSettingListR, userStatus);
    }

    //取得UserPure
    private UserPure GetUserPureData(String id) {
        //GetAllUserInfoIn upper String
        this.id = id;
        try {
            executeSQL = " Select*from UserTable where userid = \"" + id + "\"";
            //executeSQL = " Select*from UserTable";
            ResultSet rs = stmt.executeQuery(executeSQL);
            executeSQL = "";
            while (rs.next()) {
                id = rs.getString("UserId");
                idf = id;
                //UserIDArray.add(id);
                userName = rs.getString("UserName");
                usernamef = userName;
                //UserNameArray.add(userName);
                userPassword = rs.getString("UserPassword");
                passwordf = userPassword;
                //UserPasswordArray.add(userPassword);
                userM = rs.getInt("BirthdayMonth");
                userD = rs.getInt("BirthdayDate");
                //System.out.println(rs.getString("gender").charAt(0));
                gender = rs.getString("gender").charAt(0);
                genderf = gender;
                hometown = rs.getString("hometown");
                hometownf = hometown;
                phonenumber = rs.getLong("phonenumber");
                phonenumberf = phonenumber;
                //birthdayf.set(userD,userM);
                //birthday.set(userD, userM);
                //birthday.set(userD,userM);
                //UserBirthdayArray.add(birthday);
                System.out.println("id>> " + id + "/ fn>> " + userName + "/ pn>> " + userPassword + "/ bm>> " + userM + "/ bd>> " + userD + "/ SEX>>" + gender + "/ HT>>" + hometown + "/ PN>>" + phonenumber);

            }
            birthdayf = new Birthday(userD, userM);
            System.out.println("Closing Data");
        } catch (Exception e) {
            e.printStackTrace();
        }
        return new UserPure(idf, usernamef, birthdayf, passwordf, genderf, hometownf, phonenumberf);
    }

    //--
    public void getSettingByUserId(String id) {
        this.id = id;
        try {
            executeSQL = "Select*from UserSettingTable where userid = \"" + id + "\"";
            ResultSet rs = stmt.executeQuery(executeSQL);
            while (rs.next()) {
                id = rs.getString("UserId");
                idf = id;
                System.out.println("id>> " + id + "/ fn>> " + userName + "/ pn>> " + userPassword + "/ bm>> " + userM + "/ bd>> " + userD);
            }
            System.out.println("Closing Data");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    //组合取得（主方法）
    private Account AUTT(UserPure userPureAUTT, UserRemain userRemainAUTT) {
        Account account = new Account(userPureAUTT.getId(), userPureAUTT.getUserName(), userPureAUTT.getPassword());
        account.setGender(userPureAUTT.getGender());
        account.setHometown(userPureAUTT.getHometown());
        account.setPhoneNumber(userPureAUTT.getPhoneNumber());
        account.setBirthday(userPureAUTT.getBirthday());
        System.out.println("A");
        account.setFriendSettingList(userRemainAUTT.getFriendSettingList());
        account.setUserStatus(userRemainAUTT.getUserStatus());
        System.out.println("B");
        return account;
    }

    //GetM______________________________________________________________________________________________________________
    public String getId() {
        return id;
    }

    public int getUserD() {
        return userD;
    }

    public int getUserM() {
        return userM;
    }

    public String getUserName() {
        return userName;
    }

    public String getUserPassword() {
        return userPassword;
    }

    public Account getAccount(String id) {
        return AUTT(GetUserPureData(id), GetUserRemainData(id));
    }

    private void reset() {
        id = "";
        userD = 0;
        userM = 0;
        userName = "";
        userPassword = "";
        //birthday = null;
    }

    //取得Array
    public ArrayList<Account> getAccountList() {
        ArrayList<Account> accountArrayList = new ArrayList<>();
        try {
            executeSQL = " Select*from UserTable";
            ResultSet rs = stmt.executeQuery(executeSQL);
            executeSQL = "";
            while (rs.next()) {
                FriendSetting friendSetting;
                UserStatus userStatus = new UserStatus();
                FriendSettingList friendSettingLista = new FriendSettingList();
                id = rs.getString("UserId");
                //UserIDArray.add(id);
                userName = rs.getString("UserName");
                //UserNameArray.add(userName);
                userPassword = rs.getString("UserPassword");
                //UserPasswordArray.add(userPassword);
                userM = rs.getInt("BirthdayMonth");
                userD = rs.getInt("BirthdayDate");
                gender = rs.getString("gender").charAt(0);
                System.out.println("Char:" + gender + "?" + rs.getString("gender"));
                hometown = rs.getString("hometown");
                phonenumber = rs.getLong("phonenumber");
                Birthday birthday = new Birthday(userD, userM);
                UserPure userPureL = new UserPure(id, userName, birthday, userPassword, gender, hometown, phonenumber);
                //executeSQL = "select count(*) from usersettingtable;";
                //int rs3 = stmt.executeQuery(executeSQL);
                // System.out.println(rs3);
                executeSQL = "Select*from UserSettingTable where userid = \"" + id + "\"";
                ResultSet rs2 = stmt2.executeQuery(executeSQL);
                while (rs2.next()) {
                    friendSetting = new FriendSetting("", "", true);
                    //userStatus1.setStatus("Offline");
                    userStatus.logoff();
                    System.out.println(rs2.getString("Userid"));
                    friendSetting.setId(rs2.getString("FriendId"));
                    System.out.println(rs2.getString("FriendId"));
                    friendSetting.setNote(rs2.getString("userNote"));
                    System.out.println(rs2.getString("userNote"));
                    friendSetting.setDisablePost(rs2.getBoolean("DisablePost"));
                    System.out.println(rs2.getBoolean("DisablePost"));
                    friendSettingLista.addNewFriendSetting(friendSetting);
                    System.out.println("Loop inside RS:UserRemain, count " + friendSettingLista.getSize());
                    //friendID = rs.getString("FriendId");
                }
                UserRemain userRemainL = new UserRemain(id, friendSettingLista, userStatus);
                accountArrayList.add(AUTT(userPureL, userRemainL));
                int i = 1;
                System.out.println("COUNT:" + i);
                i += 1;
                //birthday.set(userD,userM);
                //UserBirthdayArray.add(birthday);
                System.out.println("id>> " + id + "/ fn>> " + userName + "/ pn>> " + userPassword + "/ bm>> " + userM + "/ bd>> " + userD + "/ SEX>>" + gender + "/ HT>>" + hometown + "/ PN>>" + phonenumber);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
        return accountArrayList;
    }

    //DT3_5_____________________________________________________________________________________________________________
    private String JsonConverter(ArrayList<String> idArray) {
        String jsonCon = gson.toJson(idArray);
        System.out.println(">>>IdArrayList Convert Completed!<<<");
        //String jsonC = "'"+jsonCon+"'";
        //System.out.println(jsonCon);
        //System.out.println(jsonC);
        return jsonCon;
    }

    private ArrayList<String> JsonConvertReverse(String jsonCon) {
        Type listType = new TypeToken<ArrayList<String>>() {
        }.getType();
        ArrayList<String> idList = gson.fromJson(jsonCon, listType);
        System.out.println(">>>IdArrayList Reverse Completed!<<<");
        return idList;
    }

    public void InsertChatGroupTable(ChatGroup chatGroup) {
        try {
            String Gid = chatGroup.getGroupId();
            String Cid = chatGroup.getCreatorId();
            String GName = chatGroup.getGroupName();
            String IdArrJson = JsonConverter(chatGroup.getAccountIdList());
            executeSQL = "insert into chatgrouptable (GroupId,GroupName,CreatorId,AccountIdListJson) values (\"" + Gid + "\",\"" + GName + "\",\"" + Cid + "\",\'" + IdArrJson + "\');";
            stmt.executeUpdate(executeSQL);
            System.out.println("Insert into ChatGroupTable is Done");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void updateChatGroup(ChatGroup chatGroup) {
        try {
            String Gid = chatGroup.getGroupId();
            String Cid = chatGroup.getCreatorId();
            String GName = chatGroup.getGroupName();
            String IdArrJson = JsonConverter(chatGroup.getAccountIdList());
            executeSQL = "Update chatgrouptable Set GroupName =\"" + GName + "\"where GroupId = \"" + Gid + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:...");
            executeSQL = "Update chatgrouptable Set CreatorId =\"" + Cid + "\"where GroupId = \"" + Gid + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:......");
            executeSQL = "Update chatgrouptable Set AccountIdListJson =\'" + IdArrJson + "\'where GroupId = \"" + Gid + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:.........");
            System.out.println("Update Done.");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void listChar() {
        try {
            executeSQL = "Select*From chatgrouptable";
            ResultSet rs = stmt.executeQuery(executeSQL);
            int i = 1;
            while (rs.next()) {
                GroupId = rs.getString("groupid");
                FoundId = rs.getString("CreatorId");
                GroupName = rs.getString("GroupName");
                String js = rs.getString("AccountIdListJson");
                idList = JsonConvertReverse(js);
                ChatGroup chatGroup = new ChatGroup(GroupName, FoundId);
                chatGroup.setAccountIdList(idList);
                chatGroup.setGroupId(GroupId);
                System.out.println("Group: " + GroupName + " Set Done");
                chatGroupList.addNewGroup(chatGroup);
                System.out.println("Group added, loop: " + i + " // List size: " + chatGroupList.getSize());
                i++;
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void DeleteGroupById(String groupId) {
        try {
            executeSQL = "Delete From chatgrouptable Where groupId = \"" + groupId + "\"";
            System.out.println(executeSQL+">>>");
            stmt.executeUpdate(executeSQL);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
    public ChatGroupList getChatGroupList() {
        return chatGroupList;
    }

    public void InsertIntoGroupMessageTable(GroupMessage groupMessage) {
        try {
            String groupId = groupMessage.getGroupId();
            String messageInfo = groupMessage.getMessageInfo();
            MessageType messageType = groupMessage.getMessageType();
            String senderId = groupMessage.getSenderId();
            DateTime time = new DateTime(groupMessage.getTime().getYear(), groupMessage.getTime().getMonth(), groupMessage.getTime().getDay(), groupMessage.getTime().getHour(), groupMessage.getTime().getMinute());
            executeSQL = "insert into groupmessagetable (GroupId,MessageInfo,MessageType,SenderId,Time) values (\"" + groupId + "\",\"" + messageInfo + "\",\"" + messageType + "\",\"" + senderId + "\",\"" + time + "\");";
            stmt.executeUpdate(executeSQL);
            System.out.println("Insert Into GroupMessageTable is Done");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void updateGroupMessage(GroupMessage groupMessage) {
        try {
            String groupId = groupMessage.getGroupId();
            String messageInfo = groupMessage.getMessageInfo();
            MessageType messageType = groupMessage.getMessageType();
            String senderId = groupMessage.getSenderId();
            DateTime time = new DateTime(groupMessage.getTime().getYear(), groupMessage.getTime().getMonth(), groupMessage.getTime().getDay(), groupMessage.getTime().getHour(), groupMessage.getTime().getMinute());
            executeSQL = "Update groupmessagetable Set MessageInfo =\"" + messageInfo + "\"where GroupId = \"" + groupId + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:...");
            executeSQL = "Update groupmessagetable Set MessageType =\"" + messageType + "\"where GroupId = \"" + groupId + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:......");
            executeSQL = "Update groupmessagetable Set SenderId =\"" + senderId + "\"where GroupId = \"" + groupId + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:...........");
            executeSQL = "Update groupmessagetable Set Time =\"" + time + "\"where GroupId = \"" + groupId + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:...............");
            System.out.println("Update done");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void listGM() {
        try {
            executeSQL = "Select*From groupmessagetable";
            ResultSet rs = stmt.executeQuery(executeSQL);
            int i = 1;
            while (rs.next()) {
                GMGroupId = rs.getString("GroupId");
                GMSenderId = rs.getString("SenderId");
                MessageInfo = rs.getString("MessageInfo");
                String eu = rs.getString("MessageType");
                messageType = Enum.valueOf(MessageType.class, eu);
                GroupMessage groupMessage = new GroupMessage(GMSenderId, GMGroupId, MessageInfo);
                groupMessage.setTime(time);
                groupMessage.setMessageType(messageType);
                System.out.println("GMGroupMessage: " + MessageInfo + " |Set");
                groupMessageList.addMessage(groupMessage);
                System.out.println("Group added, loop: " + i + " // List size: " + groupMessageList.getSize());
                i++;
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    public void DeleteGroupMessageById(String id)
    {
        try {
            executeSQL = "Delete From groupmessagetable where GroupId=\"" + id + "\"";
            stmt.executeUpdate(executeSQL);
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }
    public GroupMessageList getGroupMessageList() {
        return groupMessageList;
    }

    public void InsertIntoPrivateMessageTable(PrivateMessage privateMessage) {
        try {
            String receiverId = privateMessage.getReceiverId();
            String messageInfo = privateMessage.getMessageInfo();
            MessageType messageType = privateMessage.getMessageType();
            String senderId = privateMessage.getSenderId();
            DateTime time = new DateTime(privateMessage.getTime().getYear(), privateMessage.getTime().getMonth(), privateMessage.getTime().getDay(), privateMessage.getTime().getHour(), privateMessage.getTime().getMinute());
            executeSQL = "insert into privatemessagetable (ReceiverId,SenderId,MessageInfo,MessageType,Time) values (\"" + receiverId + "\",\"" + senderId + "\",\"" + messageInfo + "\",\"" + messageType + "\",\"" + time + "\");";
            stmt.executeUpdate(executeSQL);
            System.out.println("Insert Into PrivateMessageTable is Done");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void updatePrivateMessage(PrivateMessage privateMessage) {
        try {
            String receiverId = privateMessage.getReceiverId();
            String messageInfo = privateMessage.getMessageInfo();
            MessageType messageType = privateMessage.getMessageType();
            String senderId = privateMessage.getSenderId();
            DateTime time = new DateTime(privateMessage.getTime().getYear(), privateMessage.getTime().getMonth(), privateMessage.getTime().getDay(), privateMessage.getTime().getHour(), privateMessage.getTime().getMinute());
            executeSQL = "Update privatemessagetable Set MessageInfo =\"" + messageInfo + "\"where receiverId = \"" + receiverId + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:...");
            executeSQL = "Update privatemessagetable Set MessageType =\"" + messageType + "\"where receiverId = \"" + receiverId + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:......");
            executeSQL = "Update privatemessagetable Set SenderId =\"" + senderId + "\"where receiverId = \"" + receiverId + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:...........");
            executeSQL = "Update privatemessagetable Set Time =\"" + time + "\"where receiverId = \"" + receiverId + "\"";
            stmt.executeUpdate(executeSQL);
            System.out.println("Updating:...............");
            System.out.println("Update done");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    public void listPM() {
        try {
            executeSQL = "Select*From privatemessagetable";
            ResultSet rs = stmt.executeQuery(executeSQL);
            int i = 1;
            while (rs.next()) {
                SenderId = rs.getString("SenderId");
                ReceiverId = rs.getString("ReceiverId");
                PMessageInfo = rs.getString("MessageInfo");
                String eu = rs.getString("MessageType");
                pMessageType = Enum.valueOf(MessageType.class, eu);
                PrivateMessage privateMessage = new PrivateMessage(SenderId, ReceiverId, PMessageInfo);
                privateMessage.setTime(pTime);
                privateMessage.setMessageType(pMessageType);
                System.out.println("PMessage: " + PMessageInfo + " |Set");
                privateMessageList.addMessage(privateMessage);
                System.out.println("Message added, loop: " + i + " // List size: " + privateMessageList.getSize());
                i++;
            }
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    public void DeletePrivateMessageById(String id) {
        try {
            executeSQL = "Delete From privatemessagetable where SenderId=\"" + id + "\"";
            stmt.executeUpdate(executeSQL);
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    public PrivateMessageList getPrivateMessageList() {
        return privateMessageList;
    }
}


//--hint
// public void generateM(int BM)
// {
//     switch (BM)
//     {
//         case 1: mo = "JAN";
//         case 2:  mo = "FEB";
//         case 3:  mo = "MAR";
//         case 4:  mo = "APR";
//         case 5:  mo = "MAY";
//         case 6:  mo = "JUN";
//         case 7:  mo = "JUL";
//         case 8:  mo = "AUG";
//         case 9:  mo = "SEP";
//         case 10:  mo = "OCT";
//         case 11:  mo = "NOV";
//         default:  mo = "DEC";
//     }
//
// }
// public void generateD(int BD)
// {
//     if (BD>3)
//     {
//         da = BD+"th";
//     }
//     if (BD==1)
//     {
//         da = BD+"st";
//     }
//     if (BD==2)
//     {
//         da = BD+"nd";
//     }
//     if (BD==3)
//     {
//         da = BD+"rd";
//     }
// }
// public void assemble()
// {
//     Date.setDA(da);
//     Date.setMO(mo);
// }
// public DateClassConvert getDate()
// {
//     return Date;
// }
