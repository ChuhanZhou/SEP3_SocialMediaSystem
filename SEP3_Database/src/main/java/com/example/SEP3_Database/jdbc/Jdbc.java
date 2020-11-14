package com.example.SEP3_Database.jdbc;

import java.sql.*;

import com.google.cloud.sql.mysql.SocketFactory;
import com.mysql.cj.protocol.Resultset;

public class Jdbc
{
    static final String JDBC_DRIVER = "com.mysql.cj.jdbc.Driver";
    private static String dbUrl = "jdbc:mysql:///SEP3?cloudSqlInstance=asm-api-295017:europe-west3:sep03&socketFactory=com.google.cloud.sql.mysql.SocketFactory&user=root&password=1";
    public static void main(String[] args){
        try
        {
            Class.forName(JDBC_DRIVER);
            System.out.println("DataBaseDriveLoaded");
            DriverManager.getConnection(dbUrl);
            System.out.println("Google Drive connected");
            Connection conn = DriverManager.getConnection(dbUrl);
            Statement statement = conn.createStatement();
            System.out.println("Statement Init");
            String sql = " Select*from UserTable";
            ResultSet rs = statement.executeQuery(sql);
            while(rs.next())
            {
                int id = rs.getInt("UserId");
                String fn = rs.getString("UserName");
                String pn = rs.getString("UserPassword");
                int bm = rs.getInt("BirthdayMonth");
                int bd = rs.getInt("BirthdayDate");
                System.out.println("id>> " +id + "/ fn>> "+fn+"/ pn>> "+pn+"/ bm>> "+bm+"/ bd>> "+bd);
            }
            System.out.println("Closing Data");
            rs.close();
            statement.close();
            conn.close();
        }
        catch (Exception e)
        {
            System.out.println(e+"_____________________");
        }

    }
}
