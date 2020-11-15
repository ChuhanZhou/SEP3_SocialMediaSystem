package com.example.SEP3_Database.jdbc;

import java.sql.*;
import java.util.Date;
import java.util.Scanner;

import com.google.cloud.sql.mysql.SocketFactory;
import com.mysql.cj.protocol.Resultset;

public class Jdbc implements JDBC_interface
{
    private static final String JDBC_DRIVER = "com.mysql.cj.jdbc.Driver";
    private static String Username = "root";
    private static String Password = "0811";
    private int id;
    private String userName;
    private String userPassword;
    private int userM;
    private int userD;
    private Connection conn = null;
    private Statement stmt = null;
    String mo;
    String da;
    DateClassConvert Date = new DateClassConvert("","");
    Scanner scanner = new Scanner(System.in);
    private String executeSQL = "";
    //private static String dbUrl = "jdbc:mysql:///SEP3?cloudSqlInstance=asm-api-295017:europe-west3:sep03&socketFactory=com.google.cloud.sql.mysql.SocketFactory&user=root&password=1";
    private static String dbUrl ="jdbc:mysql://localhost:3306/sep3_local?useSSL=false&allowPublicKeyRetrieval=true&serverTimezone=UTC";
    public void init()
    {
        try {
            Class.forName(JDBC_DRIVER);
            System.out.println("DataBaseDriveLoaded");
            conn = DriverManager.getConnection(dbUrl, Username, Password);
            System.out.println(">>Sql connected<<");
            System.out.println(">>Link To SQL: " + dbUrl + " <<<");
            System.out.println(">>User And Password: " + Username + "///" + Password + " <<<");
            stmt = conn.createStatement();
            System.out.println(">>System Activated. Database all good<<");
        }
        catch (Exception e)
        {
            System.out.println(e+"_____________________");
        }
    }
    public void DeleteDatabase()
    {
        System.out.println(">>>DeleteDatabase Begin<<<");
        System.out.println("Do you want to delete your database? (Y?N)");
        String a = scanner.nextLine();
        if(a.equals("Y"))
        {
            try
            {
                executeSQL = "Drop Table UserTable";
                stmt.executeUpdate(executeSQL);
                executeSQL = "Drop Table UserSettingTable";
                stmt.executeUpdate(executeSQL);
                System.out.println(">>>DataBase delete successful<<<");
            }
            catch (Exception e)
            {
                e.printStackTrace();
            }
        }
        else {
            System.out.println("You have exited the delete function");
        }
    }



    public void CreateDataBase()
    {
        System.out.println(">>>Database Creation Begins<<<");
        System.out.println("Do you want to Create the database? (Y?N)");
        String a = scanner.nextLine();
        if(a.equals("Y")) {
            try {
                executeSQL = "CREATE TABLE `UserSettingTable` (\n" +
                        "  `UserID` varchar(45) NOT NULL,\n" +
                        "  `UserNote` varchar(45) DEFAULT NULL,\n" +
                        "  `DisablePost` tinyint(1) NOT NULL DEFAULT '0',\n" +
                        "  `UserStatus` varchar(15) NOT NULL,\n" +
                        "  PRIMARY KEY (`UserID`),\n" +
                        "  UNIQUE KEY `UserID_UNIQUE` (`UserID`)\n" +
                        ") ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;";
                stmt.executeUpdate(executeSQL);
                System.out.println("T1: UserSettingTable");
                executeSQL = "CREATE TABLE `UserTable` (\n" +
                        "  `UserId` int(11) NOT NULL,\n" +
                        "  `UserName` varchar(100) NOT NULL,\n" +
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
        }
        else System.out.println("You have exited the creation function");
    }
    //自定义

    public void setExecuteSQL(String executeSQL) throws SQLException {
        this.executeSQL = executeSQL;
        stmt.executeUpdate(executeSQL);
    }


    public void GetAllUserData(){
        //GetAllUserInfoIn upper String
        try
        {
            executeSQL = " Select*from UserTable";
            ResultSet rs = stmt.executeQuery(executeSQL);
            executeSQL = "";
            while(rs.next())
            {
                id = rs.getInt("UserId");
                userName = rs.getString("UserName");
                userPassword = rs.getString("UserPassword");
                userM = rs.getInt("BirthdayMonth");
                userD = rs.getInt("BirthdayDate");
                System.out.println("id>> " +id + "/ fn>> "+userName+"/ pn>> "+userPassword+"/ bm>> "+userM+"/ bd>> "+userD);
            }
            System.out.println("Closing Data");
           // rs.close();
           // stmt.close();
           // conn.close();
        }
        catch (Exception e)
        {
            //e.printStackTrace();
            System.out.println(e+"_____________________");
        }
    }
//getm______________________________________________________________________________________________________________________
    public int getId() {
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
