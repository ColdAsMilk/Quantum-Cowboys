<?php
$user = "klopoo027@gmail.com";
$hash = ezmlm_hash($user);

echo "The hash value for $user is: $hash.";

// the message
$msg = "First line of text\nSecond line of text";

// use wordwrap() if lines are longer than 70 characters
$msg = wordwrap($msg,70);

// send email
mail("klopoo027@gmail.com","My subject",$msg);
?>