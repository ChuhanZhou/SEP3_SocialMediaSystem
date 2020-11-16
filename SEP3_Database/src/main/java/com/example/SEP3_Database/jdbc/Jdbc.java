package com.example.SEP3_Database.jdbc;

import java.sql.*;
import java.util.Scanner;

import com.example.SEP3_Database.model.domain.list.userList.FriendSettingList;
import com.example.SEP3_Database.model.domain.unit.user.*;
import com.mysql.cj.protocol.Resultset;

public class Jdbc implements JDBC_interface {
    private Account account;
    private static final String JDBC_DRIVER = "com.mysql.cj.jdbc.Driver";
    private static String Username = "root";
    private static String Password = "0811";
    private String id;
    private String userName;
    private String userPassword;
    private int userM;
    private int userD;
    private Connection conn = null;
    private Statement stmt = null;
    String mo;
    String da;
    DateClassConvert Date = new DateClassConvert("", "");
    Scanner scanner = new Scanner(System.in);
    private String executeSQL = "";
    UserPure userPure = new UserPure("", "", null, "");
    UserRemain userRemain = new UserRemain("",null,null);
    // private ArrayList<String> UserIDArray = new ArrayList<>();
    // private ArrayList<String> UserNameArray = new ArrayList<>();
    // private ArrayList<String> UserPasswordArray = new ArrayList<>();
    // private ArrayList<Birthday> UserBirthdayArray = new ArrayList<>();
    private Birthday birthday;
    //private static String dbUrl = "jdbc:mysql:///SEP3?cloudSqlInstance=asm-api-295017:europe-west3:sep03&socketFactory=com.google.cloud.sql.mysql.SocketFactory&user=root&password=1";
    private static String dbUrl = "jdbc:mysql://localhost:3306/sep3_local?useSSL=false&allowPublicKeyRetrieval=true&serverTimezone=UTC";
    private String idf;
    private String usernamef;
    private String passwordf;
    private Birthday birthdayf;
    private int D;
    private int M;
    private FriendSettingList FSL;
    private UserStatus USS;
    public boolean init() {
        try {
            Class.forName(JDBC_DRIVER);
            System.out.println("DataBaseDriveLoaded");
            conn = DriverManager.getConnection(dbUrl, Username, Password);
            System.out.println(">>Sql connected<<");
            System.out.println(">>Link To SQL: " + dbUrl + " <<<");
            System.out.println(">>User And Password: " + Username + "///" + Password + " <<<");
            stmt = conn.createStatement();
            System.out.println(">>System Activated. Database all good<<");
            return true;
        } catch (Exception e) {
            System.out.println(e + "_____________________");
            return false;
        }
    }

    public void DeleteDatabase() {
        System.out.println(">>>DeleteDatabase Begin<<<");
        System.out.println("Do you want to delete your database? (Y?N)");
        String a = scanner.nextLine();
        if (a.equals("Y")) {
            try {
                executeSQL = "Drop Table UserTable";
                stmt.executeUpdate(executeSQL);
                executeSQL = "Drop Table UserSettingTable";
                stmt.executeUpdate(executeSQL);
                System.out.println(">>>DataBase delete successful<<<");
            } catch (Exception e) {
                e.printStackTrace();
            }
        } else {
            System.out.println("You have exited the delete function");
        }
    }


    public void CreateDataBase() {
        System.out.println(">>>Database Creation Begins<<<");
        System.out.println("Do you want to Create the database? (Y?N)");
        String a = scanner.nextLine();
        if (a.equals("Y")) {
            try {
                executeSQL = "CREATE TABLE `UserSettingTable` (\n" +
                        "  `UserID` varchar(45) NOT NULL,\n" +
                        "  `UserNote` varchar(45) DEFAULT NULL,\n" +
                        "  `DisablePost` tinyint(1) NOT NULL DEFAULT '0',\n" +
                        "  `UserStatus` varchar(1500) NOT NULL,\n" +
                        "  PRIMARY KEY (`UserID`),\n" +
                        "  UNIQUE KEY `UserID_UNIQUE` (`UserID`)\n" +
                        ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";
                stmt.executeUpdate(executeSQL);
                System.out.println("T1: UserSettingTable");
                executeSQL = "CREATE TABLE `UserTable` (\n" +
                        "  `UserName` varchar(45) NOT NULL,\n" +
                        "  `UserPassword` varchar(100) NOT NULL,\n" +
                        "  `BirthdayMonth` int(11) DEFAULT NULL,\n" +
                        "  `BirthdayDate` int(11) DEFAULT NULL,\n" +
                        "  PRIMARY KEY (`UserId`),\n" +
                        "  UNIQUE KEY `UserId_UNIQUE` (`UserId`)\n" +
                        ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";
                stmt.executeUpdate(executeSQL);
                System.out.println("T2: UserTable");
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

    //public void AddUserInDataBase(Account account) {
    //    this.account = account;
    //    //
    //}

    public void dissembleAccount(Account account) {
        String ida = account.getId();
        String usernameA = account.getUserName();
        String passwordA = account.getPasswordForDataBase();
        Birthday birthdayA = account.getBirthday();
        FriendSettingList fsl = account.getFriendSettingList();
        UserStatus uss = account.getUserStatus();
        System.out.println(getUserPure().getId() + ">>>Start dissemble and set to account pure<<<");
        assemblePure(ida, usernameA, passwordA, birthdayA);
        System.out.println(getUserPure().getId() + ">>>Start dissemble and set to account Remain<<<");
        assembleUserRemain(ida,fsl,uss);
    }

    public void assemblePure(String ids, String us, String ps, Birthday br) {
        System.out.println(getUserPure().getId() + " >>>Start to set account<<<");
        userPure.setId(ids);
        userPure.setBirthday(br);
        userPure.setPassword(ps);
        userPure.setUserName(us);
    }
    public void assembleUserRemain(String id,FriendSettingList friendSettingList, UserStatus userStatus)
    {
        System.out.println(getUserRemain().getFriendSettingList()+" >>>Start to set Remains<<<");
        userRemain.setFriendSettingList(friendSettingList);
        userRemain.setUserStatus(userStatus);
        userRemain.setId(id);
    }
    public UserPure getUserPure() {
        return userPure;
    }
    public UserRemain getUserRemain()
    {
        return userRemain;
    }
    public void insertUserInTable(Account account) {
        try {
            dissembleAccount(account);
            System.out.println(">>>Start insert User account into Database<<<");
            executeSQL = "insert into UserTable (UserId,UserName,UserPassword,BirthdayMonth,BirthdayDate) values (\"" + userPure.getId() + "\",\"" + userPure.getUserName() + "\",\"" + userPure.getPassword() + "\"," + userPure.getBirthday().getMonth() + "," + userPure.getBirthday().getDay() + ");";
            stmt.executeUpdate(executeSQL);
            //System.out.println(">>>Start insert into UserSettingsTable<<<");
            //stmt.executeUpdate(executeSQL);
            insertRemain(account);
            System.out.println("Insert done");
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
    public void insertRemain(Account account)
    {
        try
        {
            System.out.println(">>>Start insert into UserSettingsTable<<<");
            //System.out.println("Friendsize="+account.getFriendSettingList().getSize()+"?????????????");
            //System.out.println("FRIENDSIZE@="+userRemain.getFriendSettingList().getSize()+"!!!!!!!!!!!!!!!");
            for (int i = 0; i <account.getFriendSettingList().getSize() ; i++)
            {

                executeSQL = "insert into UserSettingTable(UserID,friendId,UserNote,DisablePost,UserStatus) values (\""+userRemain.getPublicUserId()+"\",\""+userRemain.getFriendSettingList().getFriendSettingByIndex(i).getId()+"\",\""+userRemain.getFriendSettingList().getFriendSettingByIndex(i).getNote()+"\",\""+TransPort(i)+"\",\""+userRemain.getUserStatus()+"\");";
                System.out.println(executeSQL);
                stmt.executeUpdate(executeSQL);
                System.out.println("Loop "+i+" is done");
            }
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }
    public int TransPort(int i)
    {
        if (userRemain.getFriendSettingList().getFriendSettingByIndex(i).isDisablePost())
        {
            return 1;
        }
        return 0;
    }
    public void UpdateDataBaseInUserTable(String id, String Username, String Password, Birthday Birthday) {
        try {
            executeSQL = "update userTable set Username = \"" + Username + "\", UserPassword = \"" + Password + "\",BirthdayMonth = \"" + Birthday.getMonth() + "\", BirthdayDate = \"" + Birthday.getDay() + "\" where UserId = \"" + id + "\";";
            stmt.executeUpdate(executeSQL);
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }

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
                //birthday.set(userD,userM);
                //UserBirthdayArray.add(birthday);
                System.out.println("id>> " + id + "/ fn>> " + userName + "/ pn>> " + userPassword + "/ bm>> " + userM + "/ bd>> " + userD);
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
    public UserRemain GetUserRemainData(String id)
    {
        FriendSettingList friendSettingListR = new FriendSettingList();
        FriendSetting friendSetting;
        String friendID = null;
        UserStatus userStatus = new UserStatus();
        this.id = id;
        try
        {
            executeSQL = "select * from userSettingTable where UserId = \""+id+"\";";
            ResultSet rs = stmt.executeQuery(executeSQL);
            executeSQL="";
            while (rs.next())
            {
                friendSetting = new FriendSetting("","",true);
                //userStatus1.setStatus("Offline");
                userStatus.logoff();
                friendSetting.DatabaseSetId(rs.getString("FriendId"));
                System.out.println(rs.getString("FriendId"));
                friendSetting.setNote(rs.getString("userNote"));
                System.out.println(rs.getString("userNote"));
                friendSetting.setDisablePost(rs.getBoolean("DisablePost"));
                System.out.println(rs.getBoolean("DisablePost"));
                friendSettingListR.addNewFriendSetting(friendSetting);
                System.out.println("Loop inside RS:UserRemain, count "+friendSettingListR.getSize());
                //friendID = rs.getString("FriendId");
            }

        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
        UserRemain userRemains = new UserRemain(id,friendSettingListR,userStatus);
        return userRemains;
    }
    public UserPure GetUserPureData(String id) {
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
                //birthdayf.set(userD,userM);
                //birthday.set(userD, userM);
                //birthday.set(userD,userM);
                //UserBirthdayArray.add(birthday);
                System.out.println("id>> " + id + "/ fn>> " + userName + "/ pn>> " + userPassword + "/ bm>> " + userM + "/ bd>> " + userD);
            }
            birthdayf = new Birthday(userD,userM);
            ///System.out.println(birthdayf);
            System.out.println("Closing Data");
            // rs.close();
            // stmt.close();
            // conn.close();
        } catch (Exception e) {
            e.printStackTrace();
            //System.out.println(e+"_____________________");
        }
        return new UserPure(idf,usernamef,birthdayf,passwordf);
    }
    public void getSettingByUserId(String id)
    {
        this.id = id;
        try {
            executeSQL = "Select*from UserSettingTable where userid = \""+id+"\"";
            ResultSet rs =stmt.executeQuery(executeSQL);
            while (rs.next()) {
                id = rs.getString("UserId");
                idf = id;
                System.out.println("id>> " + id + "/ fn>> " + userName + "/ pn>> " + userPassword + "/ bm>> " + userM + "/ bd>> " + userD);
            }
            System.out.println("Closing Data");
        }
        catch (Exception e)
        {
            e.printStackTrace();
        }
    }
    public Account AUTT(UserPure userPureAUTT,UserRemain userRemainAUTT)
    {
        Account account = new Account(userPureAUTT.getId(),userPureAUTT.getUserName(),userPureAUTT.getPassword());
        account.setBirthday(userPureAUTT.getBirthday());
        System.out.println("A");
        account.setFriendSettingList(userRemainAUTT.getFriendSettingList());
        account.setUserStatus(userRemainAUTT.getUserStatus());
        System.out.println("B");
        return account;
    }
    //getm______________________________________________________________________________________________________________________
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
    public Account getAccount(String id)
    {
       return AUTT(GetUserPureData(id),GetUserRemainData(id));
    }

    public void reset() {
        id = "";
        userD = 0;
        userM = 0;
        userName = "";
        userPassword = "";
        //birthday = null;
    }
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
}
