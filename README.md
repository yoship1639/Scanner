# Scanner
Java��Scanner�@�\��C#�Ŏ�����  
�v���~�e�B�u�^�╶����̍\����͋@�\��񋟂��܂�
��؂蕶����char.IsWhiteSpace�ɓ��Ă͂܂镶���ł�  
����T���v���Ƃ���ScannerTest�t�H�[�����܂܂�Ă��܂�  

## �@�\
���݁A�ȉ��̋@�\�����p�\�ł�  

* NextString : ���̃g�[�N����string�Ƃ��ēǂݍ��ށB�I�[������܂œǂݍ��ނ悤�w����\
* NextInt : ���̃g�[�N����int�Ƃ��ēǂݍ���
* NextFloat : ���̃g�[�N����float�Ƃ��ēǂݍ���
* NextDouble : ���̃g�[�N����double�Ƃ��ēǂݍ���
* NextDecimal : ���̃g�[�N����decimal�Ƃ��ēǂݍ���
* IsEnd : �ǂݍ��݈ʒu��������̍Ō�ɓ��B������

#### �T���v��
##### �E �uabc 123 -4.56�v�Ƃ�����������X�L��������  

    string text = "abc 123 -4.56";
    Scanner scanner = new Scanner(text);
	
	string val1 = scanner.NextString(); // "abc"��ǂݍ���
	int val2 = scanner.NextInt(); // 123��ǂݍ���
	float val3 = scanner.NextFloat(); // -4.56��ǂݍ���
