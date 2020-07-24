
// 1labView.cpp: реализация класса CMy1labView
//

#include "pch.h"
#include "framework.h"
// SHARED_HANDLERS можно определить в обработчиках фильтров просмотра реализации проекта ATL, эскизов
// и поиска; позволяет совместно использовать код документа в данным проекте.
#ifndef SHARED_HANDLERS
#include "1lab.h"
#endif

#include "1labDoc.h"
#include "1labView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CMy1labView

IMPLEMENT_DYNCREATE(CMy1labView, CView)

BEGIN_MESSAGE_MAP(CMy1labView, CView)
	// Стандартные команды печати
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CMy1labView::OnFilePrintPreview)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
END_MESSAGE_MAP()

// Создание или уничтожение CMy1labView

CMy1labView::CMy1labView() noexcept
{
	// TODO: добавьте код создания

}

CMy1labView::~CMy1labView()
{
}

BOOL CMy1labView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: изменить класс Window или стили посредством изменения
	//  CREATESTRUCT cs

	return CView::PreCreateWindow(cs);
}

// Рисование CMy1labView

void CMy1labView::OnDraw(CDC* /*pDC*/)
{
	CMy1labDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: добавьте здесь код отрисовки для собственных данных
}


// Печать CMy1labView


void CMy1labView::OnFilePrintPreview()
{
#ifndef SHARED_HANDLERS
	AFXPrintPreview(this);
#endif
}

BOOL CMy1labView::OnPreparePrinting(CPrintInfo* pInfo)
{
	// подготовка по умолчанию
	return DoPreparePrinting(pInfo);
}

void CMy1labView::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: добавьте дополнительную инициализацию перед печатью
}

void CMy1labView::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: добавьте очистку после печати
}

void CMy1labView::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	ClientToScreen(&point);
	OnContextMenu(this, point);
}

void CMy1labView::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// Диагностика CMy1labView

#ifdef _DEBUG
void CMy1labView::AssertValid() const
{
	CView::AssertValid();
}

void CMy1labView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CMy1labDoc* CMy1labView::GetDocument() const // встроена неотлаженная версия
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CMy1labDoc)));
	return (CMy1labDoc*)m_pDocument;
}
#endif //_DEBUG


// Обработчики сообщений CMy1labView
