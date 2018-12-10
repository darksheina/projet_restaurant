using System;
using RestaurationModel.DinerRoom;

namespace RestaurationModel
{
    public class Table
    {
        private int iDTable;
        private int seatNumber;
        public enum TableStatus { taken, free, dirty, book };
        private TableStatus status = TableStatus.free;
        private DinerRoom.CustomerGroup custumerGroup;
        private int rank;
        private int square;
        public Table(ref int seatNumber, ref int iDTable, ref int x, ref int y)
        {
            throw new System.Exception("Not implemented");
        }

        public int IDTable { get => iDTable; set => iDTable = value; }
        public int SeatNumber { get => seatNumber; set => seatNumber = value; }
        public TableStatus Status { get => status; set => status = value; }
        public CustomerGroup CustumerGroup { get => custumerGroup; set => custumerGroup = value; }
        public int Rank { get => rank; set => rank = value; }
        public int Square { get => square; set => square = value; }
    }
}