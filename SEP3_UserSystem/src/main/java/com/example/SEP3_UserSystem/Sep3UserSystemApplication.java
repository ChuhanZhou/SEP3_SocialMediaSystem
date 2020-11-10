package com.example.SEP3_UserSystem;

import model.UserSystemModel;
import model.UserSystemModelManager;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class Sep3UserSystemApplication {

	public static void main(String[] args) {
		SpringApplication.run(Sep3UserSystemApplication.class, args);
		UserSystemModel userSystemModel = new UserSystemModelManager();
	}

}
