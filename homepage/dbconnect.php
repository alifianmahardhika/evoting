<?php
    $db_name    = "fingerprintvb";
    $db_user    = "root";
    $db_pass    = "";
    $db_host    = "127.0.0.1";

    $conn = mysqli_connect($db_host, $db_user, $db_pass);
    if (!$conn) die("Connection for user $db_user refused!");
    mysqli_select_db($conn,$db_name) or die("Can not connect to database!");
?>