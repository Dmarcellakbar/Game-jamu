mergeInto(LibraryManager.library, {

  openPage: function (url){
  	url = Pointer_stringify(url);
	window.open(url,'_blank');
  },
});