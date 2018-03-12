<?php
	include "database_connect.php";
	$username = $_POST["username"];
	$password = $_POST["password"];
	$device_name = $_POST["device_name"];
	$name = $_POST["name"];
	$sql = "SELECT id FROM users WHERE username = '$username' AND password = '$password'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
		die("Invalid userdata");
	$row = $result->fetch_assoc();
	$user_id = $row["id"];
	$sql = "SELECT id FROM devices WHERE device_name = '$device_name'";
	$result = $conn->query($sql);
	if(!$result)
		die($conn->error);
	$row = $result->fetch_assoc();
	$device_id = $row["id"];
	$sql = "INSERT INTO home_devices (user_id, device_id, name) VALUES ('$user_id', '$device_id', '$name')";
	$result = $conn->query($sql);
	if(!$result)
		die($conn->error);
	die("Success");
?>