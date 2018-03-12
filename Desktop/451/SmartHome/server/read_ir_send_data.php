<?php
	include "database_connect.php";
	$username = $_GET["username"];
	$device_name = $_GET["device_name"];
	$button_id = $_GET["button_id"];
	$data = $_GET["data"];
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
	$sql = "UPDATE buttons SET button_data = '$data' WHERE id='$button_id'";
	$result = $conn->query($sql);
	if(!$result)
		die("Error3");
	die("Successful operation!");
?>