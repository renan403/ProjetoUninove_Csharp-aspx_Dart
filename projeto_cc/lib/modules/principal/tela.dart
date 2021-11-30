// ignore_for_file: prefer_const_constructors

import 'package:flutter/material.dart';
import 'package:card_swiper/card_swiper.dart';
import 'package:get/get.dart';

class Tela extends StatelessWidget {
  const Tela({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    final images = [
      'https://midia.agoranordeste.com.br/uploads/imagens/policia/policia_federal/maconhaa.jpg?1492658308015',
      'https://cdn.pixabay.com/photo/2016/02/10/21/59/landscape-1192669__480.jpg',
      'https://s2.glbimg.com/PWzElwICb5ItVqUPSQmj6bxMkSY=/620x455/e.glbimg.com/og/ed/f/original/2014/07/29/caverna-melissani-kefalonia-grecia.jpg',
    ];
    final noticias = [
      'Estudos indicam que maconha dá brisa',
      'Árvore eu acho',
      'Som de paisagens para ouvir durante treinamento',
    ];
    return Scaffold(
      body: ListView(
        children: [
          Padding(
            padding: const EdgeInsets.only(top: 8.0, left: 10),
            child: Text(
              'Notícias:',
              style: TextStyle(color: Colors.grey, fontSize: 20),
            ),
          ),
          SizedBox(
            width: Get.width,
            height: 200,
            child: Swiper(
              itemBuilder: (BuildContext context, int index) {
                return Image.network(
                  images[index],
                  fit: BoxFit.fill,
                );
              },
              itemCount: images.length,
              pagination: SwiperPagination(),
              autoplay: true,
            ),
          ),
          Padding(
            padding: EdgeInsets.only(top: 25, left: 10),
            child: ElevatedButton(
              child: Text('Seus Exercícios'),
              style: ElevatedButton.styleFrom(
                textStyle: TextStyle(fontSize: 25),
                primary: Colors.orange,
                fixedSize: Size(Get.width * .7, 150),
                shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(15)),
              ),
              onPressed: () {
                return null;
              },
            ),
          ),
          Padding(
            padding: EdgeInsets.only(top: 25, left: 10),
            child: ElevatedButton.icon(
              icon: Padding(
                padding: const EdgeInsets.only(left: 10),
                child: Icon(
                  Icons.person,
                  size: 50,
                ),
              ),
              label: Padding(
                padding: const EdgeInsets.only(left: 50.0),
                child: Text('Fale com Especialista'),
              ),
              style: ElevatedButton.styleFrom(
                textStyle: TextStyle(fontSize: 25),
                primary: Colors.orange,
                fixedSize: Size(Get.width * .7, 150),
                shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(15)),
              ),
              onPressed: () {
                return null;
              },
            ),
          ),
          Padding(
            padding: EdgeInsets.only(top: 25, left: 10),
            child: ElevatedButton(
              child: Text('Programação'),
              style: ElevatedButton.styleFrom(
                textStyle: TextStyle(fontSize: 25),
                primary: Colors.orange,
                fixedSize: Size(Get.width * .7, 150),
                shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(15)),
              ),
              onPressed: () {
                return null;
              },
            ),
          ),
        ],
      ),
    );
  }
}
