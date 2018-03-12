<?php
	include "database_connect.php";
	$username = $_POST["username"];
	$password = $_POST["password"];
	$device_name = $_POST["device_name"];
	$home_device_name = $_POST["home_device_name"];
	$button_name = $_POST["button_name"];
	$sql = "SELECT id FROM users WHERE username = '$username' AND password = '$password'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
		die("Invalid userdata");
	$row = $result->fetch_assoc();
	$user_id = $row["id"];
	$sql = "SELECT id FROM devices WHERE device_name = '$device_name'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
		die("Invalid device name");
	$row = $result->fetch_assoc();
	$device_id = $row["id"];
	$sql = "SELECT id FROM home_devices WHERE name = '$home_device_name'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
		die("Invalid home device name");
	$row = $result->fetch_assoc();
	$home_device_id = $row["id"];
	$sql = "UPDATE buttons SET clicked = '1' WHERE user_id = '$user_id' AND device_id = '$device_id' AND home_device_id = '$home_device_id' AND button_name = '$button_name'";
	$result = $conn->query($sql);
	if(!$result)
		die($conn->error);
	die("Success");
?>