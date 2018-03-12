<?php
	include "database_connect.php";
	$username = $_GET["username"];
	$device_name = $_GET["device_name"];
	$sql = "SELECT id FROM users WHERE username='$username'";
	$result = $conn->query($sql);
	if(!$result||$result->num_rows==0)
		die("Error1");
	$row = $result->fetch_assoc();
	$user_id = $row["id"];
	$sql = "SELECT id FROM devices WHERE device_name='$device_name'";
	$result = $conn->query($sql);
	if(!$result||$result->num_rows==0)
		die("Error2");
	$row = $result->fetch_assoc();
	$device_id = $row["id"];
	$sql = "SELECT id FROM buttons WHERE user_id='$user_id' AND device_id='$device_id' AND button_data IS NULL";
	$result = $conn->query($sql);
	if(!$result)
		die("Error3");
	if($result->num_rows==0)
		die("No data");
	$row = $result->fetch_assoc();
	$id = $row["id"];
	die(strval($id)."#");
?>