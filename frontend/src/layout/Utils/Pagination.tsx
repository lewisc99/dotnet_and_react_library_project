export const Pagination: React.FC<{
  currentPage: number;
  totalPages: number;
  paginate: any;
}> = (pagination) => {
  const pageNumbers = [];

  if (pagination.currentPage === 1) {
    pageNumbers.push(pagination.currentPage);
    if (pagination.totalPages > pagination.currentPage) {
      pageNumbers.push(pagination.currentPage + 1);
    }
  } else if (pagination.currentPage === pagination.totalPages) {
    pageNumbers.push(pagination.currentPage - 1);
    pageNumbers.push(pagination.currentPage);
  } else {
    pageNumbers.push(pagination.currentPage - 1);
    pageNumbers.push(pagination.currentPage);
    pageNumbers.push(pagination.currentPage + 1);
  }

  return (
    <nav aria-label="...">
      <ul className="pagination">
        <li className="page-item" onClick={() => pagination.paginate(1)}>
          <button className="page-link">First Page</button>
        </li>
        {pageNumbers.map((number) => (
          <li
            key={number}
            onClick={() => pagination.paginate(number)}
            className={
              "page-item " + (pagination.currentPage === number ? "active" : "")
            }
          >
            <button className="page-link">{number}</button>
          </li>
        ))}
        <li
          className="page-item"
          onClick={() => pagination.paginate(pagination.totalPages)}
        >
          <button className="page-link">Last Page</button>
        </li>
      </ul>
    </nav>
  );
};
