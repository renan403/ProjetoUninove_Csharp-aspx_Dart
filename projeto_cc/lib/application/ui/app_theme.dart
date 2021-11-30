import 'package:flutter/material.dart';

class AppTheme {
  AppTheme._(); //n deixa que a classe seja instanciada

  static String get tittle => 'OTC_HEALTH';

  static ThemeData get Theme => ThemeData(
      fontFamily: 'JosefinSans',
      scaffoldBackgroundColor: Colors.black54,
      appBarTheme: AppBarTheme(
          backgroundColor: Color(0xffFF9900),
          iconTheme: IconThemeData(color: Colors.black87),
          titleTextStyle: TextStyle(
            color: Color(0xff222222),
            fontSize: 18,
            fontWeight: FontWeight.w500,
          )));
}
