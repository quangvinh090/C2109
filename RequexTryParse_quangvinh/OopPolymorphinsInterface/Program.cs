using OopPolymorphinsInterface;

//FileOne on = new();
//on.WriteBinaryFile();
//on.WriteTextFile();
//on.ReadFile();

//((IBinaryFile)on).ShowInfor();
//(on as IBinaryFile).ShowInfor();

//FileTwo f = new();
//f.WriteBinaryFile();
//(f as IBinaryFile).ReadFile();


ITextfile itext = new FileOne();
itext.ReadFile();
itext = new FileTwo();
itext.ReadFile();   
