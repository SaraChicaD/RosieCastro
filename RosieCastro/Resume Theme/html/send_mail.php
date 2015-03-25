<?php
	$to = "coralixthemes@gmail.com"; /*Your Email*/
	$subject = "Messsage from website"; /*Issue*/
	$date = date ("l, F jS, Y"); 
	$time = date ("h:i A"); 	
	$msg="
	Subject: $_REQUEST[Subject]
	Name: $_REQUEST[Name]
	Email: $_REQUEST[Email]
	
	Message sent from website on date  $date, hour: $time.\n

	Message:
	$_REQUEST[message]";

	mail($to, $subject, $msg, "From: $_REQUEST[Email]");
	echo "Thank you for your message...";
?>
