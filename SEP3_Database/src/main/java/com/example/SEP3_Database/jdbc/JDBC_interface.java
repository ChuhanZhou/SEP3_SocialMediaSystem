package com.example.SEP3_Database.jdbc;

import com.example.SEP3_Database.model.domain.list.groupList.ChatGroupList;
import com.example.SEP3_Database.model.domain.list.message.GroupMessageList;
import com.example.SEP3_Database.model.domain.list.message.PrivateMessageList;
import com.example.SEP3_Database.model.domain.list.postList.CommentList;
import com.example.SEP3_Database.model.domain.list.postList.PostList;
import com.example.SEP3_Database.model.domain.unit.group.ChatGroup;
import com.example.SEP3_Database.model.domain.unit.message.GroupMessage;
import com.example.SEP3_Database.model.domain.unit.message.MessageType;
import com.example.SEP3_Database.model.domain.unit.message.PrivateMessage;
import com.example.SEP3_Database.model.domain.unit.post.Comment;
import com.example.SEP3_Database.model.domain.unit.post.Post;
import com.example.SEP3_Database.model.domain.unit.time.MyTime;
import com.example.SEP3_Database.model.domain.unit.user.Account;
import org.joda.time.DateTime;

import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.Scanner;
import java.util.Timer;

public interface JDBC_interface {
    public boolean init();

    public void DeleteDatabase();

    public void CreateDataBase();

    public void insertUserInTable(Account account);

    public void UpdateDataBaseInUserTable(Account account);

    public void GetAllUserData();

    public Account getAccount(String id);

    public ArrayList<Account> getAccountList();

    public void InsertChatGroupTable(ChatGroup chatGroup);

    public void updateChatGroup(ChatGroup chatGroup);

    public void listChar();

    public ChatGroupList getChatGroupList();

    public void InsertIntoGroupMessageTable(GroupMessage groupMessage);

    public void updateGroupMessage(GroupMessage groupMessage);

    public void listGM();

    public GroupMessageList getGroupMessageList();

    public void InsertIntoPrivateMessageTable(PrivateMessage privateMessage);

    public void updatePrivateMessage(PrivateMessage privateMessage);

    public void listPM();

    public void DeletePrivateMessageById(String id);

    public void DeleteGroupById(String id);

    public void DeleteGroupMessageById(String id);

    public PrivateMessageList getPrivateMessageList();

    public void UpdatePost(Post post);

    public PostList GetPost();

    public void InsertPostList(Post post);

    public void deletePostById(String id);
}

class interfacetest {

    public static void main(String[] args) {
        Jdbc_User jdbc = new Jdbc_User();
        System.out.println(jdbc.init());
//      // jdbc.GetAllUserData();
        jdbc.DeleteDatabase();
        jdbc.CreateDataBase();
        ArrayList<String> DisableList = new ArrayList<>();
        ArrayList<String> LikerList = new ArrayList<>();
        DisableList.add("u1");
        DisableList.add("u2");
        DisableList.add("u2");
        LikerList.add("U4");
        LikerList.add("U4");
        LikerList.add("U6");
        DateTime dateTime = DateTime.now();
        Post post = new Post("p1", "post", "this", DisableList);
        CommentList commentList = new CommentList();
        Comment comment = new Comment("p2", "good");
        comment.setCommentId("C1");
        Comment comment2 = new Comment("p2", "good3");
        comment2.setCommentId("C2");
        Comment comment3 = new Comment("p4", "bad");
        comment3.setCommentId("C3");
        commentList.addComment(comment);
        commentList.addComment(comment2);
        commentList.addComment(comment3);
        post.setDateTime(dateTime);
        post.setCommentList(commentList);
        post.setLikerIdList(LikerList);
        post.setPostId("Post1");
        jdbc.InsertPostList(post);
        System.out.println(jdbc.GetPost().getPostByIndex(0).getLikerIdList().get(0));
        System.out.println(jdbc.GetPost().getPostByIndex(0).getDisableList().get(0));
        System.out.println(jdbc.GetPost().getPostByIndex(0).getCommentList().getCommentByIndex(0));
        jdbc.UpdatePost(post);
        System.out.println("DEL:");

        jdbc.deletePostById("post1");
    }
}
//LocalDateTime dateTime = LocalDateTime.now();
//MyTime time = new MyTime(dateTime);
//GroupMessage PrivateMessage = new GroupMessage("a1", "a2", "helloSQL");
//PrivateMessage.setMessageType(MessageType.PRIVATE);
//PrivateMessage.setTime(time);
//jdbc.InsertIntoGroupMessageTable(PrivateMessage);
//PrivateMessage.setMessageInfo("goodbySql");
//jdbc.InsertIntoGroupMessageTable(PrivateMessage);
//jdbc.listPM();
//jdbc.listGM();
// System.out.println(jdbc.getGroupMessageList().getMessageByIndex(0).getMessageInfo());
//ChatGroup chatGroup = new ChatGroup("test", "12a");
//chatGroup.setGroupId("g1");
//ArrayList<String> idList = new ArrayList<>();
//idList.add("a1");
//idList.add("a2");
//idList.add("a3");
//chatGroup.setAccountIdList(idList);
//jdbc.InsertChatGroupTable(chatGroup);
//jdbc.listChar();
//System.out.println(jdbc.getChatGroupList().getGroupByIndex(0).getAccountIdList().get(1));
//chatGroup.setCreatorId("21a");
//chatGroup.setGroupName("not test");
//idList.add("a4");
//chatGroup.setAccountIdList(idList);
//        jdbc.updateChatGroup(chatGroup);
//        System.out.println("Are you sure to delete");
//        Scanner scanner = new Scanner(System.in);
//        String next = scanner.nextLine();
//        if (next.equals("y")) {
//            jdbc.DeleteGroupById("g1");
//        } else {
//            System.out.println("Exited");
//        }
//        //
//        //
//        //
//        //
//        //
//        //
//        //
//        //System.out.println(jdbc.getPrivateMessageList().getMessageByIndex(0).getMessageType());
//        //PrivateMessage.setMessageInfo("GoodBySql");
//        //PrivateMessage.setSenderId("a4");
//        //jdbc.updatePrivateMessage(PrivateMessage);
//
//    }
////        //jdbc.getAccount("a1");
////        //System.out.println(jdbc.getAccount("a1").getId()+" :DATA>>>"+jdbc.getAccount("a1").getUserName()+"PS>>>"+jdbc.getAccount("a1").getPasswordForDataBase());
////        //System.out.println(jdbc.getAccount("a1").getFriendSettingList().getFriendSettingByIndex(0));
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