package com.example.SEP3_Database.jdbc;

public interface JDBC_interface {
    public void init();
    public void GetAllUserData();
    public int getId();
    public int getUserD();
    public int getUserM();
    public String getUserName();
    public String getUserPassword();
   // public void generateM(int BM);
   // public void generateD(int BD);
   // public DateClassConvert getDate();
   // public void assemble();

}
class interfacetest
        {

            public static void main(String[] args) {
                Jdbc jdbc = new Jdbc();
                jdbc.init();
                jdbc.GetAllUserData();
                jdbc.DeleteDatabase();
                jdbc.GetAllUserData();
             //   jdbc.generateD(jdbc.getUserD());
             //   jdbc.generateM(jdbc.getUserM());
             //   jdbc.assemble();
             //   System.out.println("MO:>>> "+jdbc.getDate().getMO()+"///DA:>>> "+jdbc.getDate().getDA());
            }
        }