// ignore_for_file: prefer_const_constructors

import 'package:projeto_cc/modules/login/login_control.dart';
import 'package:flutter/material.dart';
import 'package:flutter_signin_button/button_list.dart';
import 'package:flutter_signin_button/button_view.dart';
import 'package:get/get.dart';

class LoginPage extends GetView<LoginControler> {
  const LoginPage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Stack(
        alignment: Alignment.topCenter,
        children: [
          Image.asset(
            'assets/images/background.png',
            width: Get.width,
            height: Get.height,
            fit: BoxFit.cover,
          ),
          Container(
            color: Colors.black45,
          ),
          SingleChildScrollView(
            child: Padding(
              padding: const EdgeInsets.only(top: 150),
              child: Column(
                children: [
                  Image.asset('assets/images/logoOTC.png'),

                  Padding(
                    padding: const EdgeInsets.only(top: 120),
                    child: Container(
                      width: Get.width * .8,
                      height: 65,
                      //color: Colors.white,
                      decoration: BoxDecoration(
                          borderRadius: BorderRadius.all(Radius.circular(100))),
                      child: TextFormField(
                        validator: (value) =>
                            value!.isEmpty ? "Informe o Usuário" : null,
                        textAlign: TextAlign.center,
                        style: const TextStyle(
                            color: Colors.black, fontSize: 20.0),
                        decoration: const InputDecoration(
                          fillColor: Colors.white,
                          filled: true,
                          labelText: "Usuário",
                          labelStyle: TextStyle(color: Colors.black54),
                        ),
                      ),
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.only(top: 10),
                    child: Container(
                      width: Get.width * .8,
                      height: 65,
                      //color: Colors.white,
                      decoration: BoxDecoration(
                          borderRadius: BorderRadius.all(Radius.circular(100))),
                      child: TextFormField(
                        validator: (value) =>
                            value!.isEmpty ? "Informe a senha" : null,
                        textAlign: TextAlign.center,
                        style: const TextStyle(
                            color: Colors.black, fontSize: 20.0),
                        decoration: const InputDecoration(
                          fillColor: Colors.white,
                          filled: true,
                          labelText: "Senha",
                          labelStyle: TextStyle(color: Colors.black54),
                        ),
                      ),
                    ),
                  ),
                  // SizedBox(
                  //   width: Get.width * .7,
                  //   height: 50,
                  //   child: SignInButton(
                  //     Buttons.Google,
                  //     shape: RoundedRectangleBorder(
                  //         borderRadius: BorderRadius.circular(100)),
                  //     onPressed: () => controller.login(),
                  //     text: 'Entrar Com Google',
                  //   ),
                  // ),
                  Padding(
                    padding: const EdgeInsets.only(right: 100, top: 1),
                    child: TextButton(
                      child: Text('ainda não tem conta?'),
                      style: TextButton.styleFrom(
                        primary: Colors.blue,
                        fixedSize: Size(Get.width * .5, 5),
                      ),
                      onPressed: () {
                        print('pressed');
                      },
                    ),
                  ),
                  Padding(
                    padding: const EdgeInsets.only(right: 200, top: 10),
                    child: ElevatedButton(
                      child: Text('Login'),
                      style: ElevatedButton.styleFrom(
                        primary: Colors.grey,
                        fixedSize: Size(Get.width * .3, 30),
                        shape: RoundedRectangleBorder(
                            borderRadius: BorderRadius.circular(10)),
                      ),
                      onPressed: () {
                        print('pressed');
                      },
                    ),

                    // child: SizedBox(
                    //   width: Get.width * .7,
                    //   height: 50,
                    //   child: SignInButton(
                    //     Buttons.Email,
                    //     shape: RoundedRectangleBorder(
                    //         borderRadius: BorderRadius.circular(100)),
                    //     onPressed: () => controller.login(),
                    //     text: 'Entrar Com email',
                    //   ),
                  ),

                  // Obx(() {
                  //   return Text(
                  //     controller.nome.value,
                  //     style: TextStyle(
                  //       color: Colors.white,
                  //       fontSize: 20,
                  //     ),
                  //   );
                  // })
                ],
              ),
            ),
          ),
        ],
      ),
    );
  }
}
