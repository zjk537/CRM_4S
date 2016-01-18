<?php
/**
 *
 * @authors zjk (zhangjie1@yicai.com)
 * @date    2016-01-06
 */

// include "person.class.php";
// $objSoapServer = new SoapServer("person.wsdl"); //person.wsdl是刚创建的wsdl文件
// //$objSoapServer = new SoapServer("server.php?wsdl");//这样也行
// $objSoapServer->setClass("person"); //注册person类的所有方法
// $objSoapServer->handle(); //处理请求

require_once 'person.class.php';

// Enciende el servidor o despliega WSDL
if (isset($_SERVER['REQUEST_METHOD']) && $_SERVER['REQUEST_METHOD'] == 'POST') {
    $servidorSoap = new SoapServer('http://' . $_SERVER['SERVER_NAME'] . ':' . $_SERVER['SERVER_PORT'] . $_SERVER['PHP_SELF'] . '?wsdl');
    $servidorSoap->setClass('person');
    $servidorSoap->handle();
} else {
    require_once '../SoapDiscovery.class.php';

    // Crea el servidor de descubrimiento
    $disco = new SoapDiscovery('person', 'test_person');
    header("Content-type: text/xml");
    if (isset($_SERVER['QUERY_STRING']) && strcasecmp($_SERVER['QUERY_STRING'], 'wsdl') == 0) {
        echo $disco->getWSDL();
    } else {
        echo $disco->getDiscovery();
    }
}
