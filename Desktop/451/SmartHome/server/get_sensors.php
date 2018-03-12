<?php
	include "database_connect.php";
	$username = $_POST["username"];
	$password = $_POST["password"];
	$device_name = $_POST["device_name"];
	$sql = "SELECT id FROM users WHERE username = '$username' AND password = '$password'";
	$result = $conn->query($sql);
	if($result->num_rows == 0)
		die("Invalid userdata");
	$row = $result->fetch_assoc();
	$user_id = $row["id"];
	$sql = "SELECT id FROM devices WHERE user_id = '$user_id' AND device_name = '$device_name'";
	$result = $conn->query($sql);
	if(!$result)
		die($conn->error);
	$row = $result->fetch_assoc();
	$device_id = $row["id"];
	$sql = "SELECT * FROM sensors_data WHERE user_id = '$user_id' AND device_id = '$device_id'";
	$result = $conn->query($sql);
	if(!$result)
		die($conn->error);
	$row = $result->fetch_assoc();
	die($row["temp_cel"]."#".$row["temp_far"]."#".$row["heat_index_cel"]."#".$row["heat_index_far"]."#".$row["hum"]."#".$row["lux"]."#".$row["gas_ppm"]);
?>