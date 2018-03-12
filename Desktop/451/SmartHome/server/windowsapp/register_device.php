<?php
	include "../database_connect.php";
	$device_name = $_POST["name"];
	$username = $_POST["username"];
	$sql = "SELECT id FROM users WHERE username='$username'";
	$result = $conn->query($sql);
	if(!$result)
		die($conn->error);
	$row = $result->fetch_assoc();
	$user_id = $row["id"];
	$sql = "INSERT INTO devices (user_id, device_name) VALUES ('$user_id', '$device_name')";
	$result = $conn->query($sql);
	if(!$result)
		die($conn->error);
	die("1");
?>