using C_;

ReportWriter reportWriter=new ReportWriter();
Notification notification=new Notification();
reportWriter.OnNotificationHub += notification.sendEmail;
reportWriter.writeReport();

