using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

namespace RobotGaitDesignDemo
{
    internal class ExcelProcess
    {
        public static DataSet ParseExcelToDataSet(string filePath)
        {
            DataSet ds = new DataSet();

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook;

                // 根据文件扩展名判断使用HSSFWorkbook还是XSSFWorkbook
                string fileExtension = Path.GetExtension(filePath).ToLower();
                if (fileExtension == ".xlsx")
                {
                    workbook = new XSSFWorkbook(fileStream);
                }
                else if (fileExtension == ".xls")
                {
                    workbook = new HSSFWorkbook(fileStream);
                }
                else
                {
                    throw new ArgumentException("不支持的文件格式");
                }

                // 遍历所有Sheet
                for (int sheetIndex = 0; sheetIndex < workbook.NumberOfSheets; sheetIndex++)
                {
                    ISheet sheet = workbook.GetSheetAt(sheetIndex);
                    string sheetName = sheet.SheetName;

                    // 创建DataTable，名称为Sheet名称
                    DataTable dataTable = new DataTable(sheetName);

                    if (sheet.LastRowNum >= 0)
                    {
                        IRow headerRow = sheet.GetRow(0);
                        int columnCount = headerRow.LastCellNum;

                        // 获取有效列的数量（跳过空列）
                        List<int> validColumnIndexes = new List<int>();
                        for (int col = 0; col < columnCount; col++)
                        {
                            ICell cell = headerRow.GetCell(col);
                            if (cell != null && !string.IsNullOrEmpty(cell.ToString().Trim()))
                            {
                                validColumnIndexes.Add(col);
                            }
                        }

                        // 创建列
                        for (int i = 0; i < validColumnIndexes.Count; i++)
                        {
                            dataTable.Columns.Add($"Column{i + 1}", typeof(string));
                        }

                        // 填充数据行
                        for (int rowIndex = 0; rowIndex <= sheet.LastRowNum; rowIndex++)
                        {
                            IRow row = sheet.GetRow(rowIndex);
                            if (row == null) continue;

                            DataRow dataRow = dataTable.NewRow();
                            bool hasData = false;

                            for (int i = 0; i < validColumnIndexes.Count; i++)
                            {
                                int colIndex = validColumnIndexes[i];
                                ICell cell = row.GetCell(colIndex);

                                string cellValue = GetCellValue(cell);
                                dataRow[i] = cellValue;

                                if (!string.IsNullOrEmpty(cellValue))
                                {
                                    hasData = true;
                                }
                            }

                            // 只有当该行至少有一个单元格有数据时才添加
                            if (hasData)
                            {
                                dataTable.Rows.Add(dataRow);
                            }
                        }
                    }

                    // 将DataTable添加到DataSet中
                    ds.Tables.Add(dataTable);
                }
            }

            return ds;
        }

        /// <summary>
        /// 获取单元格的值（字符串格式）
        /// </summary>
        private static string GetCellValue(ICell cell)
        {
            if (cell == null)
            {
                return string.Empty;
            }

            switch (cell.CellType)
            {
                case CellType.Numeric:
                    // 判断是否为日期格式
                    if (DateUtil.IsCellDateFormatted(cell))
                    {
                        return cell.DateCellValue.ToString("yyyy-MM-dd HH:mm:ss");
                    }

                    // 如果是整数，不显示小数点后的0
                    double numericValue = cell.NumericCellValue;
                    if (numericValue == Math.Floor(numericValue))
                    {
                        return ((long)numericValue).ToString();
                    }
                    return numericValue.ToString();

                case CellType.String:
                    return cell.StringCellValue.Trim();

                case CellType.Boolean:
                    return cell.BooleanCellValue.ToString();

                case CellType.Formula:
                    try
                    {
                        // 尝试获取公式计算结果
                        return cell.NumericCellValue.ToString();
                    }
                    catch
                    {
                        try
                        {
                            return cell.StringCellValue.Trim();
                        }
                        catch
                        {
                            return cell.ToString();
                        }
                    }

                case CellType.Blank:
                    return string.Empty;

                case CellType.Error:
                    return $"#ERROR: {cell.ErrorCellValue}";

                default:
                    return cell.ToString().Trim();
            }
        }


    }
}
