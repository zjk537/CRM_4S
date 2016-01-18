<?php
/**
 *
 * @authors zjk (zhangjie1@yicai.com)
 * @date    2016-01-06
 */

try {
    $client = new SoapClient(null,
        array('location' => "http://localhost/4s_crm/Test/TestServer.php", 'uri' => "http://localhost/4s_crm/")
    );
    echo $client->run();

} catch (SoapFault $fault) {
    echo "Error: ", $fault->faultcode, ", string: ", $fault->faultstring;
}
