package com.example.SEP3_UserSystem;

import com.example.SEP3_UserSystem.mediator.ServerConnector;
import com.example.SEP3_UserSystem.model.UserSystemModel;
import com.example.SEP3_UserSystem.model.UserSystemModelManager;
import com.example.SEP3_UserSystem.model.domain.unit.user.FriendSetting;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class Sep3UserSystemApplication {

	public static void main(String[] args) {
		SpringApplication.run(Sep3UserSystemApplication.class, args);
		UserSystemModel userSystemModel = UserSystemModelManager.getModelManager();
		ServerConnector server = new ServerConnector(userSystemModel);
		Thread thread = new Thread(server,"[UserSystemServer]");
		thread.setDaemon(true);
		thread.start();
	}

}
