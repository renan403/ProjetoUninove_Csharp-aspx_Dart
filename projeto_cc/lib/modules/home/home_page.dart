// ignore_for_file: prefer_const_constructors

import 'package:flutter/material.dart';
import 'package:get/get.dart';
import 'package:projeto_cc/modules/config/config_page.dart';
import 'package:projeto_cc/modules/home/home_bindings.dart';
import 'package:projeto_cc/modules/home/home_controller.dart';
import 'package:projeto_cc/modules/principal/tela.dart';
import 'package:projeto_cc/modules/programa%C3%A7%C3%A3o/data_page.dart';

class HomePage extends GetView<HomeController> {
  const HomePage({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        leading: IconButton(
          onPressed: () {
            print('side bar');
          },
          icon: Icon(Icons.list_rounded),
          iconSize: 40,
        ),
        actions: [
          IconButton(
            onPressed: () {
              print('lupa');
            },
            icon: Icon(Icons.search_rounded),
            iconSize: 40,
          )
        ],
        title: Center(
          child: Image.asset(
            'assets/images/logoOTC.png',
            scale: 2,
          ),
        ), //Center(child: Text('OTC_HEALTH')),
      ),
      bottomNavigationBar: Obx(() {
        return BottomNavigationBar(
          backgroundColor: Color(0xff251A68),
          unselectedItemColor: Colors.white,
          selectedItemColor: Color(0xffFF9900),
          onTap: controller.goToPage,
          currentIndex: controller.pageIndex,
          // ignore: prefer_const_literals_to_create_immutables
          items: [
            BottomNavigationBarItem(
                icon: Icon(Icons.home), label: 'tela inicial'),
            BottomNavigationBarItem(
                icon: Icon(Icons.query_builder_rounded), label: 'programação'),
            BottomNavigationBarItem(
                icon: Icon(Icons.settings_applications_outlined),
                label: 'configuração'),
          ],
        );
      }),
      body: Navigator(
        initialRoute: '/main',
        key: Get.nestedKey(HomeController.NAVIGATOR_KEY),
        onGenerateRoute: (settings) {
          if (settings.name == '/main') {
            return GetPageRoute(
              settings: settings,
              page: () => Tela(),
            );
          }
          if (settings.name == '/config') {
            return GetPageRoute(
              settings: settings,
              page: () => ConfigPage(),
            );
          }
          if (settings.name == '/tempo') {
            return GetPageRoute(
              settings: settings,
              page: () => DataPage(),
            );
          }
        }, //responsavel pela navegação
      ), //navegação interna pra n perder bootom navigation e appbar
    );
  }
}
