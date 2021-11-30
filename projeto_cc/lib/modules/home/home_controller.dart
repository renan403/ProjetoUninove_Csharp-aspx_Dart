import 'package:get/get.dart';

class HomeController extends GetxController {
  static const NAVIGATOR_KEY = 1;
  static const INDEX_PAGE_EXIT = 2;

  final _pages = ['/main', '/tempo', '/config'];

  final _pageIndex = 0.obs;

  int get pageIndex => _pageIndex.value;

  void goToPage(int page) {
    _pageIndex(page);
    Get.offNamed(_pages[page], id: NAVIGATOR_KEY);
    // if (page == 1) {
    //   Get.offNamed('/tempo', id: NAVIGATOR_KEY);
    // } else if (page == 2) {
    //   Get.offNamed('/config', id: NAVIGATOR_KEY);
    // } else if (page == 0) {
    //   Get.offNamed('/main', id: NAVIGATOR_KEY);
    // }
  }
}
