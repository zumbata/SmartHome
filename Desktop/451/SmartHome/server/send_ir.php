<?php
	include "database_connect.php";
	$username = $_GET["username"];
	$device_name = $_GET["device_name"];
	$sql = "SELECT id FROM users WHERE username='$username'";
	$result = $conn->query($sql);
	if(!$result||$result->num_rows==0)
		die("Error1 ".$conn->error);
	$row = $result->fetch_assoc();
	$user_id = $row["id"];
	$sql = "SELECT id FROM devices WHERE device_name='$device_name'";
	$result = $conn->query($sql);
	if(!$result||$result->num_rows==0)
		die("Error2 ".$conn->error);
	$row = $result->fetch_assoc();
	$device_id = $row["id"];
	$sql = "SELECT button_name, position, button_data FROM buttons WHERE user_id='$user_id' AND device_id='$device_id' AND clicked=1";
	$result = $conn->query($sql);
	if(!$result)
		die("Error3 ".$conn->error);
	if($result->num_rows==0)
		die("No data");
	$row = $result->fetch_assoc();
	$name = $row["name"];
	$data = $row["button_data"];
	$position = $row["position"];
	$len = (substr_count($data[0], " ")+1)/2;
	$sql = "UPDATE buttons SET clicked=0 WHERE user_id = '$user_id' AND device_id = '$device_id' AND button_name = '$name'";
	$result = $conn->query($sql);
	if(!$result)
		die("Error4 ".$conn->error);
	die(strval($len)." ".$position." ".$data."      ");
?>