<?php
	include "database_connect.php";
	$username = $_POST["username"];
	$password = $_POST["password"];
	$device_name = $_POST["device_name"];
	$home_device_name = $_POST["home_device_name"];
	$button_name = $_POST["name"];
	$position = $_POST["position"];
	$sql = "SELECT id FROM users WHERE username='$username' AND password='$password'";
	$result = $conn->query($sql);
	if(!$result||$result->num_rows==0)
		die("Invalid userdata!");
	$row = $result->fetch_assoc();
	$user_id = $row["id"];
	$sql = "SELECT id FROM devices WHERE device_name='$device_name'";
	$result = $conn->query($sql);
	if(!$result||$result->num_rows==0)
		die("Invalid device name!");
	$row = $result->fetch_assoc();
	$device_id = $row["id"];
	$sql = "SELECT id FROM home_devices WHERE name='$home_device_name'";
	$result = $conn->query($sql);
	if(!$result||$result->num_rows==0)
		die("Invalid home-device name!");
	$row = $result->fetch_assoc();
	$home_device_id = $row["id"];
	$sql = "INSERT INTO buttons (user_id, device_id, home_device_id, button_name, position, clicked) VALUES ('$user_id', '$device_id', '$home_device_id', '$button_name', '$position', 0)";
	$result = $conn->query($sql);
	if(!$result)
		die("Error uploading data!".$conn->error);
	die("Success");
?>