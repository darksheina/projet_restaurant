using RestaurantDinerRoom.DinerRoom;
using System;

namespace RestaurantDinerRoom
{
    public class Table
    {
        public int IDTable;
        public int seatNumber;
        public enum TableStatus { taken, free, dirty, book };
        public TableStatus status = TableStatus.free;
        public CustomerGroup custumerGroup;
        public int rank;
        public int square;

        public Table(int seatNumber, int iDTable, int rank, int square)
        {
            this.SeatNumber = seatNumber;
            this.IDTable = iDTable;
            this.Rank = rank;
            this.Square = square;
        }

        public int GetIDTable()
        {
            return this.IDTable;
        }
        public void SetIDTable(int iDTable)
        {
            this.IDTable = iDTable;
        }
        public int SeatNumber { get { return seatNumber; } set { seatNumber = value; } }
        public TableStatus Status { get { return status; } set { status = value; } }
        public CustomerGroup CustumerGroup { get { return custumerGroup; } set { custumerGroup = value; } }
        public int Rank { get { return rank; } set { rank = value; } }
        public int Square { get { return square; } set { square = value; } }
    }
}